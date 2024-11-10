using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_Bill_DAL : BasicMethods<tbl_DM_Bill_DTO>
    {
        public override void AddData(tbl_DM_Bill_DTO obj)
        {
            try
            {
                tbl_DM_Bill v_objRes = new tbl_DM_Bill();
                CUtility.Clone_Entity(obj, v_objRes);

                DBDataContext.tbl_DM_Bills.InsertOnSubmit(v_objRes);
                DBDataContext.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override List<tbl_DM_Bill_DTO> GetList()
        {
            try
            {
                List<tbl_DM_Bill_DTO> v_arrRes = new List<tbl_DM_Bill_DTO>();
                foreach (tbl_DM_Bill v_objBill in DBDataContext.tbl_DM_Bills)
                {
                    tbl_DM_Bill_DTO v_objRes = new tbl_DM_Bill_DTO();
                    CUtility.Clone_Entity(v_objBill, v_objRes);
                    v_arrRes.Add(v_objRes);
                }
                return v_arrRes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void UpdateData(tbl_DM_Bill_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }
    }

}
