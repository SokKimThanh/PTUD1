using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // báo cáo doanh thu phim và tổng số vé bán được
    public class tbl_Report_Sales_DAL
    {
        // ADO.NET xây dựng báo cáo doanh thu
        // chuỗi kết nối
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        // Hàm báo cáo doanh thu
        public List<tbl_Report_Sales_DTO> GetSalesReport(DateTime startDate, DateTime endDate)
        {
            // ket qua tra ve
            List<tbl_Report_Sales_DTO> result = new List<tbl_Report_Sales_DTO>();

            // bat loi
            try
            {
                // ket noi csdl
                using (var db = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var reportList = from ve in db.tbl_DM_Tickets

                                         // kết bảng lịch chiếu và vé
                                     join lichChieu in db.tbl_DM_MovieSchedules
                                     on ve.TK_MOVIESCHEDULE_AutoID equals lichChieu.MS_AutoID

                                     // kết bảng phim và lịch chiếu
                                     join phim in db.tbl_DM_Movies
                                     on lichChieu.MS_MOVIE_AutoID equals phim.MV_AutoID

                                     // Điều kiện tìm vé đã bán theo ngày và kết quả chưa bị xóa
                                     where ve.CREATED >= startDate && ve.CREATED <= endDate && ve.DELETED == 0

                                     // Nhóm kết quả theo phim và vé để tính doanh thu từng phim
                                     group new { ve, phim } by phim.MV_NAME into phimGroup

                                     // lấy kết quả
                                     select new tbl_Report_Sales_DTO
                                     {
                                         MovieName = phimGroup.Key,// doanh thu từng phim
                                         TotalRevenue = phimGroup.Sum(t => (decimal)t.ve.TK_AutoID),// tổng tiền đã thu
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
    }
}
