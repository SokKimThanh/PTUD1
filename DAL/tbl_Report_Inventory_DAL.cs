using DevExpress.DataAccess.Sql;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DAL
    {
        //    BEGIN
        //SELECT
        //    PD.PD_NAME AS ProductName,          -- Tên sản phẩm
        //    PD.PD_QUANTITY AS CurrentStock,     -- Số lượng hiện có trong kho
        //    ISNULL(SUM(BL.BL_QUANTITY), 0) AS SoldQuantity -- Số lượng đã bán(nếu có)
        //FROM tbl_DM_Product PD
        //LEFT JOIN tbl_DM_Bill BL ON PD.PD_AutoID = BL.BL_PRODUCT_AutoID
        //WHERE PD.DELETED = 0                   -- Bỏ qua các sản phẩm đã xóa
        //GROUP BY PD.PD_NAME, PD.PD_QUANTITY;
        //    END;
        private readonly string connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        public List<tbl_Report_Inventory_DTO> GetDetailedInventoryReport()
        {
            using (var db = new CM_Cinema_DBDataContext(connectionString))
            {
                var report = (from pd in db.tbl_DM_Products
                              where pd.DELETED == 0
                              join bl in db.tbl_DM_Bills on pd.PD_AutoID equals bl.BL_PRODUCT_AutoID into billGroup
                              from b in billGroup.DefaultIfEmpty()
                              group b by new { pd.PD_AutoID, pd.PD_NAME, pd.PD_IMAGEURL, pd.PD_QUANTITY, pd.PD_PRICE } into g
                              let soldQuantity = g.Sum(x => x != null ? x.BL_QUANTITY : 0)
                              let stockStatus = g.Key.PD_QUANTITY < 10 ? "Cạn kiệt" :
                                                g.Key.PD_QUANTITY > 100 ? "Quá tải" : "Có sẵn"
                              let salesPerformance = soldQuantity < 10 ? "Bán chậm" :
                                                     soldQuantity >= 10 && soldQuantity <= 50 ? "Ổn định" : "Cháy hàng"
                              select new tbl_Report_Inventory_DTO
                              {
                                  ProductID = g.Key.PD_AutoID,
                                  ProductName = g.Key.PD_NAME,
                                  ProductImageUrl = g.Key.PD_IMAGEURL,
                                  CurrentStock = g.Key.PD_QUANTITY,
                                  SoldQuantity = soldQuantity,
                                  UnitPrice = g.Key.PD_PRICE,
                                  TotalInventoryValue = g.Key.PD_QUANTITY * g.Key.PD_PRICE,
                                  SalesPerformance = salesPerformance,
                                  StockStatus = stockStatus,
                                  RecommendedAction = (salesPerformance == "Cháy hàng" && stockStatus == "Cạn kiệt") ? "Cần nhập hàng" :
                                                      (salesPerformance == "Bán chậm" && stockStatus == "Quá tải") ? "Cân nhắc chạy khuyến mãi" :
                                                      "Tiếp tục bán"
                              })
              .OrderBy(r => r.ProductName)
              .ToList();


                return report;
            }
        }
        public List<tbl_Report_Inventory_DTO> GetInventoryReportByStatus()
        {
            using (var db = new CM_Cinema_DBDataContext(connectionString))
            {
                var report = (from pd in db.tbl_DM_Products
                              where pd.DELETED == 0
                              join bl in db.tbl_DM_Bills on pd.PD_AutoID equals bl.BL_PRODUCT_AutoID into billGroup
                              from b in billGroup.DefaultIfEmpty()
                              group b by new { pd.PD_AutoID, pd.PD_NAME, pd.PD_IMAGEURL, pd.PD_QUANTITY, pd.PD_PRICE } into g
                              select new tbl_Report_Inventory_DTO
                              {
                                  ProductID = g.Key.PD_AutoID,
                                  ProductName = g.Key.PD_NAME,
                                  ProductImageUrl = g.Key.PD_IMAGEURL,
                                  CurrentStock = g.Key.PD_QUANTITY,
                                  SoldQuantity = g.Sum(x => x != null ? x.BL_QUANTITY : 0),
                                  UnitPrice = g.Key.PD_PRICE,
                                  TotalInventoryValue = g.Key.PD_QUANTITY * g.Key.PD_PRICE,
                                  StockStatus = g.Key.PD_QUANTITY < 10 ? "Hết hàng" :
                                                g.Key.PD_QUANTITY > 100 ? "Quá tải" : "Có sẵn",
                                  RecommendedAction = g.Key.PD_QUANTITY < 10 ? "Cần nhập hàng" :
                                                      g.Key.PD_QUANTITY > 100 ? "Cần chạy khuyến mãi" : "Tiếp tục bán hàng"
                              })
                              .OrderBy(r => r.ProductName)
                              .ToList();


                return report;
            }
        }
    }
}
