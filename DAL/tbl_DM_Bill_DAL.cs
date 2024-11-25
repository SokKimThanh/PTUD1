using DevExpress.CodeParser.Diagnostics;
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

        public void RemoveData(long p_lngAuto_ID, string p_strUpdated_By, string p_strUpdated_By_Function)
        {
            try
            {
                tbl_DM_Bill v_objRes = DBDataContext.tbl_DM_Bills.SingleOrDefault(it => it.BL_AutoID == p_lngAuto_ID);
                if (v_objRes != null)
                {
                    v_objRes.DELETED = 1;
                    v_objRes.UPDATED = DateTime.Now;
                    v_objRes.UPDATED_BY = p_strUpdated_By;
                    v_objRes.UPDATED_BY_FUNCTION = p_strUpdated_By_Function;


                    DBDataContext.SubmitChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public tbl_DM_Bill_DTO Get_Data_By_ID(long p_lngAuto_ID)
        {
            try
            {
                tbl_DM_Bill_DTO v_objRes = new tbl_DM_Bill_DTO();
                tbl_DM_Bill v_objBill = DBDataContext.tbl_DM_Bills.FirstOrDefault(it => it.BL_AutoID == p_lngAuto_ID);

                if (v_objBill != null)
                {
                    CUtility.Clone_Entity(v_objBill, v_objRes);
                }
                return v_objRes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_DM_Bill_DTO Get_Data_By_Code(string p_strCode)
        {
            try
            {
                tbl_DM_Bill_DTO v_objRes = new tbl_DM_Bill_DTO();
                tbl_DM_Bill v_objBill = DBDataContext.tbl_DM_Bills.FirstOrDefault(it => it.BL_Bill_Code.Trim() == p_strCode.Trim());

                if (v_objBill != null)
                {
                    CUtility.Clone_Entity(v_objBill, v_objRes);
                }
                return v_objRes;
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

        public void UpdateData(long p_lngAuto_ID, double v_dblGia)
        {
            try
            {

                tbl_DM_Bill v_objRes = DBDataContext.tbl_DM_Bills.SingleOrDefault(it => it.BL_AutoID == p_lngAuto_ID);
                if (v_objRes != null)
                {
                    v_objRes.BL_Total_Price = v_dblGia;
                }

                DBDataContext.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}
