using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Bao_Cao
{
    public class tbl_Report_BUS
    {
        private tbl_Report_Sales_DAL data = new tbl_Report_Sales_DAL();

        // Hàm báo cáo doanh thu
        public List<tbl_Report_Sales_DTO> GetAllSalesReport(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return data.GetSalesReport(ngayBatDau, ngayKetThuc);
        }

        /// <summary>
        /// Hàm tạo báo cáo doanh thu chi tiết
        /// </summary>
        /// <param name="dateTime1"></param>
        /// <param name="dateTime2"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetDetailSaleReport(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return data.GetDetailSaleReport(ngayBatDau, ngayKetThuc);
        }

        // Hàm báo cáo thu chi
        // hàm báo cáo tồn kho
    }
}
