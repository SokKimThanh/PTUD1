using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_BillDetail_DAL : BasicMethods<tbl_DM_BillDetail_DTO>
    {

        public override void AddData(tbl_DM_BillDetail_DTO obj)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    tbl_DM_BillDetail v_obj = new tbl_DM_BillDetail();
                    CUtility.Clone_Entity(obj, v_obj);

                    dbContext.tbl_DM_BillDetails.InsertOnSubmit(v_obj);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbl_DM_BillDetail_DTO> GetList_By_Bill_ID(long p_lngBill_ID)
        {
            List<tbl_DM_BillDetail_DTO> v_arrRes = new List<tbl_DM_BillDetail_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    foreach (tbl_DM_BillDetail v_objData in dbContext.tbl_DM_BillDetails.Where(it => it.BD_BILL_AutoID == p_lngBill_ID))
                    {
                        tbl_DM_BillDetail_DTO v_objItem = new tbl_DM_BillDetail_DTO();

                        CUtility.Clone_Entity(v_objData, v_objItem);

                        v_arrRes.Add(v_objItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return v_arrRes;
        }

        public override List<tbl_DM_BillDetail_DTO> GetList()
        {
            List<tbl_DM_BillDetail_DTO> v_arrRes = new List<tbl_DM_BillDetail_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    foreach (tbl_DM_BillDetail v_objData in dbContext.tbl_DM_BillDetails)
                    {
                        tbl_DM_BillDetail_DTO v_objItem = new tbl_DM_BillDetail_DTO();

                        CUtility.Clone_Entity(v_objData, v_objItem);

                        v_arrRes.Add(v_objItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return v_arrRes;
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
