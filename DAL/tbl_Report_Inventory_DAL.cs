using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DAL
    {
        private readonly string connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        public List<tbl_Report_Inventory_DTO> GetInventoryReport(DateTime startDate, DateTime endDate)
        {
            using (var dbContext = new CM_Cinema_DBDataContext(connectionString))
            {
                // Bước 1: Dữ liệu nhận hàng
                var receivedData = dbContext.tbl_SYS_Expenses
                    .Where(ex => ex.CREATED >= startDate && ex.CREATED <= endDate)
                    .GroupBy(ex => ex.EX_EXTYPE_AutoID)
                    .Select(g => new
                    {
                        ProductID = g.Key,
                        TotalReceived = g.Sum(x => x.EX_QUANTITY) // Tổng số lượng nhập
                    }); // Dữ liệu đã tải

                // Bước 2: Dữ liệu bán hàng
                var soldData = dbContext.tbl_DM_BillDetails
                    .Join(dbContext.tbl_DM_Bills, bd => bd.BD_BILL_AutoID, b => b.BL_AutoID, (bd, b) => new { bd, b })
                    .Where(x => x.b.CREATED >= startDate && x.b.CREATED <= endDate)
                    .GroupBy(x => x.bd.BD_PRODUCT_AutoID)
                    .Select(g => new
                    {
                        ProductID = g.Key,
                        TotalSold = g.Sum(x => x.bd.BD_QUANTITY) // Tổng số lượng bán
                    });  // Dữ liệu đã tải

                // Bước 3: Truy vấn tổng hợp tồn kho
                var inventoryData = from pd in dbContext.tbl_DM_Products
                                    join r in receivedData on pd.PD_AutoID equals r.ProductID into receivedJoin
                                    from r in receivedJoin.DefaultIfEmpty()
                                    join s in soldData on pd.PD_AutoID equals s.ProductID into soldJoin
                                    from s in soldJoin.DefaultIfEmpty()
                                    where pd.DELETED == 0
                                    //  ProductID: Mã sản phẩm.
                                    //  ProductName: Tên sản phẩm.
                                    //  ReceivedQuantity: Tổng số lượng nhập.
                                    //  SoldQuantity: Tổng số lượng bán.
                                    //  RemainingStock: Tồn kho = Số lượng nhận - Số lượng bán.
                                    select new tbl_Report_Inventory_DTO
                                    {
                                        ProductID = pd.PD_AutoID,
                                        ProductName = pd.PD_NAME,
                                        ReceivedQuantity = r == null ? 0 : r.TotalReceived, // Kiểm tra r null
                                        SoldQuantity = s == null ? 0 : s.TotalSold,         // Kiểm tra s null
                                        RemainingStock = (r == null ? 0 : r.TotalReceived) -
                                                         (s == null ? 0 : s.TotalSold)    // Kiểm tra cả hai
                                    };
                // Bước 4: Kết quả
                var result = inventoryData.OrderBy(x => x.ProductName);
                return result.ToList();

            }
        }

        public List<tbl_Report_Inventory_DTO> GetInventoryReportByStatusAndDate(
     DateTime startDate,
     DateTime endDate,
     int salesPerformanceThreshold = 50,
     int minStockThreshold = 50,
     double desiredProfitMargin = 0.2,
     int? inventoryStatus = 0)
        {
            using (var dbContext = new CM_Cinema_DBDataContext(connectionString))
            {
                // Số liệu nhập hàng
                var received = from ex in dbContext.tbl_SYS_Expenses
                               where ex.CREATED >= startDate && ex.CREATED <= endDate
                               group ex by ex.EX_EXTYPE_AutoID into g
                               select new
                               {
                                   ProductID = g.Key,
                                   TotalReceived = g.Sum(x => x.EX_QUANTITY),
                                   TotalImportCost = g.Sum(x => x.EX_PRICE),
                                   UnitCost = g.Sum(x => x.EX_QUANTITY) > 0 ? g.Sum(x => x.EX_PRICE) / g.Sum(x => x.EX_QUANTITY) : 0
                               };

                // Số liệu bán hàng (sản phẩm)
                var sold = from bd in dbContext.tbl_DM_BillDetails
                           join bill in dbContext.tbl_DM_Bills on bd.BD_BILL_AutoID equals bill.BL_AutoID
                           join product in dbContext.tbl_DM_Products on bd.BD_PRODUCT_AutoID equals product.PD_AutoID
                           where bill.CREATED >= startDate && bill.CREATED <= endDate
                           group new { bd, product } by bd.BD_PRODUCT_AutoID into g
                           select new
                           {
                               ProductID = g.Key,
                               TotalSold = g.Sum(x => x.bd.BD_QUANTITY),
                               ProductRevenue = g.Sum(x => x.bd.BD_QUANTITY * x.product.PD_PRICE),
                               UnitPrice = g.Max(x => x.product.PD_PRICE)
                           };

                // Kết hợp các dữ liệu
                var result = from product in dbContext.tbl_DM_Products
                             join r in received on product.PD_AutoID equals r.ProductID into receivedGroup
                             from r in receivedGroup.DefaultIfEmpty()
                             join s in sold on product.PD_AutoID equals s.ProductID into soldGroup
                             from s in soldGroup.DefaultIfEmpty()
                             where product.DELETED == 0
                             let restockStatus = (r != null && s != null && (r.TotalReceived - s.TotalSold) < minStockThreshold)
                                 ? "Cần nhập hàng" : "Đủ hàng"
                             where inventoryStatus == null ||
                                   (inventoryStatus == 0 && restockStatus == "Cần nhập hàng") ||
                                   (inventoryStatus == 1 && restockStatus == "Đủ hàng")
                             select new tbl_Report_Inventory_DTO
                             {
                                 ProductID = product.PD_AutoID,
                                 ProductName = product.PD_NAME,
                                 ReceivedQuantity = r != null ? r.TotalReceived : 0,
                                 TotalImportCost = r != null ? r.TotalImportCost : 0,
                                 UnitCost = r != null ? r.UnitCost : 0,
                                 SoldQuantity = s != null ? s.TotalSold : 0,
                                 UnitPrice = s != null ? s.UnitPrice : 0,
                                 TotalRevenue = (s != null ? s.ProductRevenue : 0),
                                 RestockStatus = restockStatus
                             };

                return result.OrderBy(x => x.ProductName).ToList();
            }
        }
    }
}
