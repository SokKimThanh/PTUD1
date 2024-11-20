using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_BillDetail_DAL : BasicMethods<tbl_DM_BillDetail_DTO>
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;
        public override void AddData(tbl_DM_BillDetail_DTO obj)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    tbl_DM_BillDetail entity = new tbl_DM_BillDetail
                    {
                        BD_BILL_AutoID = obj.BD_BILL_AutoID,
                        BD_PRODUCT_AutoID = obj.BD_PRODUCT_AutoID,
                        BD_QUANTITY = obj.BD_QUANTITY,
                        DELETED = 0,
                        CREATED = DateTime.Now,
                        CREATED_BY = CCommon.MaDangNhap,
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = CCommon.MaDangNhap,
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_DM_BillDetails.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<tbl_DM_BillDetail_DTO> GetList()
        {
            throw new NotImplementedException();
        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public override void UpdateData(tbl_DM_BillDetail_DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
