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
    /// Báo cáo thu chi
    /// </summary>
    public class tbl_Report_Expense_DAL
    {
        //        CREATE PROCEDURE sp_GetExpenseReport
        //    @StartDate DATETIME,
        //    @EndDate DATETIME
        //AS
        //BEGIN
        //    SELECT
        //        SUM(EX.EX_PRICE* EX.EX_QUANTITY) AS TotalExpenses, -- Tổng chi phí
        //        COUNT(EX.EX_AutoID) AS NumberOfExpenses             -- Số lượng chi phí
        //    FROM tbl_SYS_Expense EX
        //    WHERE EX.CREATED BETWEEN @StartDate AND @EndDate       -- Khoảng thời gian
        //    AND EX.DELETED = 0;                                    -- Bỏ qua các chi phí đã xóa
        //END;
        private readonly string connectionString = CConfig.CM_Cinema_DB_ConnectionString;
        public List<tbl_Report_Expense_DTO> GetExpenseReport(DateTime startDate, DateTime endDate)
        {
            List<tbl_Report_Expense_DTO> result = new List<tbl_Report_Expense_DTO>();

            try
            {
                using (var db = new CM_Cinema_DBDataContext(connectionString))
                {
                    var list = from ex in db.tbl_SYS_Expenses
                               where ex.CREATED >= startDate && ex.CREATED <= endDate && ex.DELETED == 0
                               group ex by 1 into exGroup
                               select new tbl_Report_Expense_DTO()
                               {
                                   TotalExpenses = exGroup.Sum(t => t.EX_PRICE * t.EX_QUANTITY),
                                   NumberOfExpenses = exGroup.Count()
                               };
                    result = list.ToList();
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
