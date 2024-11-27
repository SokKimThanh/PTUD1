using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    // báo cáo doanh thu phim và tổng số vé bán được
    public class tbl_Report_Sales_DAL
    {
        // ADO.NET xây dựng báo cáo doanh thu
        // chuỗi kết nối
        private readonly string connectionString = CConfig.CM_Cinema_DB_ConnectionString;



        // Hàm báo cáo doanh thu tổng quan
        public List<tbl_Report_Sales_DTO> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            // ket qua tra ve
            List<tbl_Report_Sales_DTO> result = new List<tbl_Report_Sales_DTO>();

            // bat loi
            try
            {
                // ket noi csdl
                using (var db = new CM_Cinema_DBDataContext(connectionString))
                {
                    var reportList = from ve in db.tbl_DM_Tickets

                                         // kết bảng lịch chiếu và vé
                                     join suatChieu in db.tbl_DM_MovieSchedules
                                     on ve.TK_MOVIESCHEDULE_AutoID equals suatChieu.MS_AutoID

                                     // kết bảng phim và lịch chiếu
                                     join phim in db.tbl_DM_Movies
                                     on suatChieu.MS_MOVIE_AutoID equals phim.MV_AutoID

                                     // Điều kiện tìm vé đã bán theo ngày và kết quả chưa bị xóa
                                     where ve.CREATED >= startDate && ve.CREATED <= endDate && ve.DELETED == 0

                                     // Nhóm kết quả theo phim và vé để tính doanh thu từng phim
                                     group new { ve, phim } by phim.MV_NAME into phimGroup

                                     // lấy kết quả
                                     select new tbl_Report_Sales_DTO
                                     {
                                         MovieName = phimGroup.Key,// doanh thu từng phim
                                         TotalRevenue = phimGroup.Sum(t => (decimal)t.phim.MV_PRICE),// tổng tiền đã thu
                                         TotalTicketsSold = phimGroup.Count(),// tổng vé đã bán
                                     };

                    result = reportList.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<TicketRevenueDTO> GetTicketRevenue(DateTime startDate, DateTime endDate)
        {
            using (var dbContext = new CM_Cinema_DBDataContext(connectionString))
            {
                var ticketRevenue = from movie in dbContext.tbl_DM_Movies
                                    join ticket in dbContext.tbl_DM_Tickets
                                        on movie.MV_AutoID equals ticket.TK_MOVIESCHEDULE_AutoID into ticketGroup
                                    from ticket in ticketGroup.DefaultIfEmpty()
                                    where ticket.CREATED >= startDate && ticket.CREATED <= endDate
                                    group ticket by new { movie.MV_AutoID, movie.MV_NAME, movie.MV_PRICE } into g
                                    select new TicketRevenueDTO
                                    {
                                        MovieID = (int)g.Key.MV_AutoID,
                                        MovieName = g.Key.MV_NAME,
                                        TicketPrice = (decimal)g.Key.MV_PRICE,
                                        TotalTickets = g.Count(),
                                        TotalTicketRevenue = (decimal)(g.Count() * g.Key.MV_PRICE)
                                    };

                return ticketRevenue.OrderByDescending(r => r.TotalTicketRevenue).ToList();
            }
        }
        public List<ProductRevenueDTO> GetProductRevenue(DateTime startDate, DateTime endDate)
        {
            using (var dbContext = new CM_Cinema_DBDataContext(connectionString))
            {
                var productRevenue = from product in dbContext.tbl_DM_Products
                                     join billDetail in dbContext.tbl_DM_BillDetails
                                         on product.PD_AutoID equals billDetail.BD_PRODUCT_AutoID into billGroup
                                     from billDetail in billGroup.DefaultIfEmpty()
                                     where billDetail.CREATED >= startDate && billDetail.CREATED <= endDate
                                     group billDetail by new { product.PD_AutoID, product.PD_NAME, product.PD_PRICE } into g
                                     select new ProductRevenueDTO
                                     {
                                         ProductID = (int)g.Key.PD_AutoID,
                                         ProductName = g.Key.PD_NAME,
                                         UnitPrice = (decimal)g.Key.PD_PRICE,
                                         TotalQuantitySold = (int)g.Sum(b => b != null ? b.BD_QUANTITY : 0),
                                         TotalProductRevenue = (decimal)g.Sum(b => b != null ? b.BD_QUANTITY * g.Key.PD_PRICE : 0)
                                     };

                return productRevenue.OrderByDescending(r => r.TotalProductRevenue).ToList();
            }
        }
    }
}
