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
        private tbl_Report_Expense_DAL ex = new tbl_Report_Expense_DAL();
        private tbl_Report_Inventory_DAL inventory_DAL = new tbl_Report_Inventory_DAL();

        // Hàm báo cáo doanh thu
        public List<tbl_Report_Sales_DTO> GetAllSalesReport(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return data.GetSalesReport(ngayBatDau, ngayKetThuc);
        }

        /// <summary>
        /// Hàm tạo báo cáo doanh thu chi tiết
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public object GetDetailSaleReport(DateTime startDate, DateTime endDate)
        {
            return data.GetDetailSaleReport(startDate, endDate);
        }

        /// <summary>
        /// Hàm báo cáo thu chi
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<tbl_Report_Expense_DTO> GetExpenseReport(DateTime startDate, DateTime endDate)
        {
            return ex.GetExpenseReport(startDate, endDate);
        }
        // hàm báo cáo tồn kho
        public List<tbl_Report_Inventory_DTO> GetDetailedInventoryReport()
        {
            return inventory_DAL.GetDetailedInventoryReport();
        }
        public List<tbl_Report_Inventory_DTO> GetInventoryReportByStatus()
        {
            return inventory_DAL.GetInventoryReportByStatus();
        }
    }
}
