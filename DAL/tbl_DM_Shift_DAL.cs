using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class tbl_DM_Shift_DAL : BasicMethods<tbl_DM_Shift_DTO>
    {

        public override void AddData(tbl_DM_Shift_DTO obj)
        {
            if (obj.SF_NAME.Trim() == "")
                throw new Exception("Tên ca làm không được để trống.");

            tbl_DM_Shift objCheck = DBDataContext.tbl_DM_Shifts.FirstOrDefault(it => it.SF_NAME.Trim() == obj.SF_NAME.Trim() && it.DELETED == 0);
            if (objCheck != null)
                throw new Exception("Tên ca làm đã tồn tại");

            tbl_DM_Shift objNew = new tbl_DM_Shift();
            CUtility.Clone_Entity(obj, objNew);

            DBDataContext.tbl_DM_Shifts.InsertOnSubmit(objNew);
            DBDataContext.SubmitChanges();
        }

        public override List<tbl_DM_Shift_DTO> GetList()
        {
            List<tbl_DM_Shift_DTO> arrRes = new List<tbl_DM_Shift_DTO>();
            List<tbl_DM_Shift> arrDB = DBDataContext.tbl_DM_Shifts.Where(it => it.DELETED == 0).OrderByDescending(it => it.SF_AutoID).ToList();

            foreach (tbl_DM_Shift objDB in arrDB)
            {
                tbl_DM_Shift_DTO objNew = new tbl_DM_Shift_DTO();
                CUtility.Clone_Entity(objDB, objNew);
                arrRes.Add(objNew);
            }

            return arrRes;
        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_Shift objRes = DBDataContext.tbl_DM_Shifts.SingleOrDefault(it => it.SF_AutoID == id);

            if (objRes != null)
            {
                objRes.DELETED = 1;
                objRes.UPDATED = DateTime.Now;
                objRes.UPDATED_BY = strUpdated_By;
                objRes.UPDATED_BY_FUNCTION = strUpdated_By_Function;
                DBDataContext.SubmitChanges();
            }
        }

        public override void UpdateData(tbl_DM_Shift_DTO obj)
        {
            if (obj.SF_NAME.Trim() == "")
                throw new Exception("Tên ca làm không được rỗng.");


            //Kiểm tra xem mã đăng nhập có tồn tại
            tbl_DM_Shift objCheck = DBDataContext.tbl_DM_Shifts.FirstOrDefault(it => it.SF_AutoID != obj.SF_AutoID &&
                                        it.SF_NAME.Trim() == obj.SF_NAME.Trim() && it.DELETED == 0);

            if (objCheck != null)
                throw new Exception("Tên ca làm đã tồn tại");

            tbl_DM_Shift objRes = DBDataContext.tbl_DM_Shifts.SingleOrDefault(it => it.SF_AutoID == obj.SF_AutoID);

            if (objRes != null)
            {
                objRes.SF_NAME = obj.SF_NAME.Trim();
                objRes.SF_START = obj.SF_START;
                objRes.SF_END = obj.SF_END;
                objRes.UPDATED = obj.UPDATED;
                objRes.UPDATED_BY = obj.UPDATED_BY.Trim();
                objRes.UPDATED_BY_FUNCTION = obj.UPDATED_BY_FUNCTION.Trim();

                DBDataContext.SubmitChanges();
            }

        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }


    }
}
