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
        public List<tbl_Report_Sales_DTO> GetSalesReport(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return data.GetSalesReport(ngayBatDau, ngayKetThuc);
        }

        // Hàm báo cáo thu chi
        // hàm báo cáo tồn kho
    }
}
