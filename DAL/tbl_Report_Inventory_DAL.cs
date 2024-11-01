using DevExpress.DataAccess.Sql;
using DTO.Custom;
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

        public List<tbl_DM_AgeRating_DAL> GetDetailedInventoryReport()
        {
            using(var db = new CM_Cinema_DBDataContext(connectionString))
            {
                var detail = from s in db.tbl_DM_Products
                             
            }
        }
        public 
    }
}
