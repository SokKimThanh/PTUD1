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
    int salesPerformanceThreshold = 50,     // hiệu suất bán hàng
    int minStockThreshold = 50,            // ngưỡng tồn kho
    double desiredProfitMargin = 0.2,      // lợi nhuận mong muốn
    int inventoryStatus = 0                // trạng thái kho (0 = tất cả, 1 = cần nhập hàng, 2 = tồn kho đủ)
)
        {
            using (var dbContext = new CM_Cinema_DBDataContext(connectionString))
            {
                var query = from pd in dbContext.tbl_DM_Products
                            where pd.DELETED == 0
                            join ex in dbContext.tbl_SYS_Expenses
                                on pd.PD_AutoID equals ex.EX_EXTYPE_AutoID into exGroup
                            from ex in exGroup.DefaultIfEmpty()
                            where ex.CREATED >= startDate && ex.CREATED <= endDate

                            join bd in dbContext.tbl_DM_BillDetails
                                on pd.PD_AutoID equals bd.BD_PRODUCT_AutoID into bdGroup
                            from bd in bdGroup.DefaultIfEmpty()
                            where bd.CREATED >= startDate && bd.CREATED <= endDate

                            group new { ex, bd } by new { pd.PD_AutoID, pd.PD_NAME } into g
                            let totalReceived = g.Sum(x => x.ex != null ? x.ex.EX_QUANTITY : 0)
                            let totalSold = g.Sum(x => x.bd != null ? x.bd.BD_QUANTITY : 0)
                            let remainingStock = totalReceived - totalSold

                            let percent = totalSold * 100.0 / totalReceived
                            let salesPerformancePercentage = totalReceived == 0 ? 0 : percent

                            let totalImportCost = g.Sum(x => x.ex != null ? x.ex.EX_PRICE : 0)
                            let totalRevenue = g.Sum(x => x.bd != null ? x.bd.BD_QUANTITY * x.bd.tbl_DM_Product.PD_PRICE : 0)
                            let profit = totalRevenue - totalImportCost

                            let stockStatus = remainingStock < minStockThreshold ? 1 : 2 // 1 = cần nhập hàng, 2 = tồn kho đủ
                            select new tbl_Report_Inventory_DTO()
                            {
                                ProductID = g.Key.PD_AutoID,
                                ProductName = g.Key.PD_NAME,
                                TotalReceived = totalReceived,
                                TotalSold = totalSold,
                                RemainingStock = remainingStock,
                                SalesPerformancePercentage = salesPerformancePercentage,
                                SalesPerformanceCategory = totalReceived == 0
                                    ? "Cần nhập hàng"
                                    : salesPerformancePercentage < salesPerformanceThreshold
                                        ? "Bán chậm"
                                        : salesPerformancePercentage <= salesPerformanceThreshold + 20
                                            ? "Hiệu suất ổn định"
                                            : "Mặt hàng hot",
                                StockStatus = stockStatus == 1 ? "Cần nhập hàng" : "Tồn kho đủ",
                                TotalImportCost = totalImportCost,
                                TotalRevenue = totalRevenue,
                                Profit = profit,
                                InventoryStatus = stockStatus // Trạng thái kho theo kiểu số
                            };

                // Lọc theo trạng thái nếu inventoryStatus khác 0
                if (inventoryStatus > 0)
                {
                    query = query.Where(x => x.InventoryStatus == inventoryStatus);
                }

                return query.OrderBy(x => x.ProductName).ToList();
            }
        }

    }
}
