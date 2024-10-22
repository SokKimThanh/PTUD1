using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class tbl_DM_Staff_DAL : BasicMethods<tbl_DM_Staff_DTO>
    {
        public override void AddData(tbl_DM_Staff_DTO obj)
        {
            tbl_DM_Staff objNew = new tbl_DM_Staff();
            CUtility.Clone_Entity(obj, objNew);

            DBDataContext.tbl_DM_Staffs.InsertOnSubmit(objNew);
            DBDataContext.SubmitChanges();
        }

        public override List<tbl_DM_Staff_DTO> GetList()
        {
            List<tbl_DM_Staff_DTO> arrRes = new List<tbl_DM_Staff_DTO>();
            List<tbl_DM_Staff> arrDB = DBDataContext.tbl_DM_Staffs.Where(it => it.DELETED != null || it.DELETED != 1).ToList();

            foreach (tbl_DM_Staff objDB in arrDB)
            {
                tbl_DM_Staff_DTO objNew = new tbl_DM_Staff_DTO();
                CUtility.Clone_Entity(objDB, objNew);
                arrRes.Add(objNew);
            }

            return arrRes;
        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_Staff objRes = DBDataContext.tbl_DM_Staffs.SingleOrDefault(it => it.ST_AutoID == id);

            if (objRes != null)
            {
                objRes.DELETED = 1;
                objRes.UPDATED = DateTime.Now;
                objRes.UPDATED_BY = strUpdated_By;
                objRes.UPDATED_BY_FUNCTION = strUpdated_By_Function;
                DBDataContext.SubmitChanges();
            }
        }

        public override void UpdateData(tbl_DM_Staff_DTO obj)
        {
            tbl_DM_Staff objRes = DBDataContext.tbl_DM_Staffs.SingleOrDefault(it => it.ST_AutoID == obj.ST_AutoID);

            if (objRes != null)
            {
                CUtility.Clone_Entity(obj, objRes);
                DBDataContext.SubmitChanges();
            }

        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }


    }
}
