using DAL.tbl_DAL;
using DevExpress.DataAccess.Sql;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DAL
    {
        private readonly string connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        public List<tbl_Report_Inventory_DTO> GetInventoryReport()
        {
            using (var db = new CM_Cinema_DBDataContext(connectionString))
            {
                var report = (from pd in db.tbl_DM_Products
                              where pd.DELETED == 0

                              //// Tổng số lượng bán
                              //let soldQuantity = db.tbl_DM_Bills
                              //                     .Where(bl => bl.BL_PRODUCT_AutoID == pd.PD_AutoID)
                              //                     .Sum(bl => (int?)bl.BL_QUANTITY) ?? 0

                              //// Tổng số lượng nhập
                              //let receivedQuantity = db.tbl_SYS_Expenses
                              //                         .Where(ex => ex.EX_EXTYPE_AutoID == pd.PD_AutoID)
                              //                         .Sum(ex => (int?)ex.EX_QUANTITY) ?? 0

                              //// Tính tồn kho hiện tại
                              //let currentStock = pd.PD_QUANTITY + receivedQuantity - soldQuantity

                              //// Đánh giá trạng thái tồn kho và hiệu suất bán hàng
                              //let stockStatus = currentStock < InventorySettings.LowStockThreshold ? "Cạn kiệt" :
                              //                  currentStock > InventorySettings.OverstockThreshold ? "Quá tải" : "Có sẵn"
                              //let salesPerformance = soldQuantity < InventorySettings.SlowSalesThreshold ? "Bán chậm" :
                              //                       soldQuantity >= InventorySettings.SlowSalesThreshold 
                              //                       && soldQuantity <= InventorySettings.StableSalesThreshold ? "Ổn định" : "Cháy hàng"

                              select new tbl_Report_Inventory_DTO
                              {
                                  //ProductID = pd.PD_AutoID,
                                  ProductName = pd.PD_NAME,
                                  //CurrentStock = currentStock,
                                  //SoldQuantity = soldQuantity,
                                  UnitPrice = pd.PD_PRICE,
                                  //TotalInventoryValue = currentStock * pd.PD_PRICE,
                                  //SalesPerformance = salesPerformance,
                                  //StockStatus = stockStatus,
                                  //RecommendedAction = (salesPerformance == "Cháy hàng" && stockStatus == "Cạn kiệt") ? "Cần nhập hàng" : (salesPerformance == "Bán chậm" && stockStatus == "Quá tải") ? "Cân nhắc chạy khuyến mãi" : "Tiếp tục bán"
                              })
                .OrderBy(r => r.ProductName)
                .ToList();

                return report;
            }
        }

        public List<tbl_Report_Inventory_DTO> GetInventoryReportByStatusAndDate(
              int stockStatus,         // 1 = Cạn kiệt, 2 = Có sẵn, 3 = Quá tải
              int salesPerformance,    // 1 = Bán chậm, 2 = Ổn định, 3 = Cháy hàng
              DateTime startDate,
              DateTime endDate)
        {
            using (var db = new CM_Cinema_DBDataContext(connectionString))
            {
                var report = (from pd in db.tbl_DM_Products
                              where pd.DELETED == 0

                              //// Tổng số lượng bán trong khoảng thời gian
                              //let soldQuantity = db.tbl_DM_Bills
                              //                     .Where(bl => bl.BL_PRODUCT_AutoID == pd.PD_AutoID
                              //                                  && bl.CREATED >= startDate
                              //                                  && bl.CREATED <= endDate)
                              //                     .Sum(bl => (int?)bl.BL_QUANTITY) ?? 0

                              //// Tổng số lượng nhập trong khoảng thời gian
                              //let receivedQuantity = db.tbl_SYS_Expenses
                              //                         .Where(ex => ex.EX_EXTYPE_AutoID == pd.PD_AutoID
                              //                                      && ex.CREATED >= startDate
                              //                                      && ex.CREATED <= endDate)
                              //                         .Sum(ex => (int?)ex.EX_QUANTITY) ?? 0

                              //// Tính tồn kho hiện tại dựa trên số lượng ban đầu, đã nhập và đã bán
                              //let currentStock = pd.PD_QUANTITY + receivedQuantity - soldQuantity

                              select new tbl_Report_Inventory_DTO
                              {
                                  //ProductID = pd.PD_AutoID,
                                  ProductName = pd.PD_NAME,
                                  //CurrentStock = currentStock,
                                  //SoldQuantity = soldQuantity,
                                  UnitPrice = pd.PD_PRICE,
                                  //TotalInventoryValue = currentStock * pd.PD_PRICE,

                                  // Xác định trạng thái tồn kho
                                  //StockStatus = currentStock < InventorySettings.LowStockThreshold ? "Cạn kiệt" : currentStock > InventorySettings.OverstockThreshold ? "Quá tải" : "Có sẵn",

                                  // Xác định hiệu suất bán hàng
                                  //SalesPerformance = soldQuantity < InventorySettings.SlowSalesThreshold ? "Bán chậm" : soldQuantity >= InventorySettings.SlowSalesThreshold && soldQuantity <= InventorySettings.StableSalesThreshold ? "Ổn định" : "Cháy hàng",

                                  // Đề xuất hành động
                                  //RecommendedAction = (currentStock < InventorySettings.LowStockThreshold && soldQuantity > InventorySettings.StableSalesThreshold) ? "Cần nhập hàng" : (currentStock > InventorySettings.OverstockThreshold && soldQuantity < InventorySettings.SlowSalesThreshold) ? "Cân nhắc mở khuyến mãi" : "Tiếp tục bán"
                              })
                      .Where(r =>
                          (stockStatus == 1 && r.StockStatus == "Cạn kiệt") ||
                          (stockStatus == 2 && r.StockStatus == "Có sẵn") ||
                          (stockStatus == 3 && r.StockStatus == "Quá tải")
                      )
                      .Where(r =>
                          (salesPerformance == 1 && r.SalesPerformance == "Bán chậm") ||
                          (salesPerformance == 2 && r.SalesPerformance == "Ổn định") ||
                          (salesPerformance == 3 && r.SalesPerformance == "Cháy hàng")
                      )
                      .OrderBy(r => r.ProductName)
                      .ToList();

                return report;
            }
        }

    }
}
