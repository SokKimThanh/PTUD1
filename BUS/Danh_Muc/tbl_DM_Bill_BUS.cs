using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Bill_BUS
    {
        public void AddData(tbl_DM_Bill_DTO p_objData)
        {
            tbl_DM_Bill_DAL v_objDal = new tbl_DM_Bill_DAL();
            try
            {
                v_objDal.AddData(p_objData);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<tbl_DM_Bill_DTO> List_Data()
        {
            tbl_DM_Bill_DAL v_objDal = new tbl_DM_Bill_DAL();
            try
            {
               return v_objDal.GetList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_DM_Bill_DTO Get_Data_By_ID(long p_lngAuto_ID)
        {
            tbl_DM_Bill_DAL v_objDal = new tbl_DM_Bill_DAL();
            try
            {
                return v_objDal.Get_Data_By_ID(p_lngAuto_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_DM_Bill_DTO Get_Data_By_Code(string p_strCode)
        {
            tbl_DM_Bill_DAL v_objDal = new tbl_DM_Bill_DAL();
            try
            {
                return v_objDal.Get_Data_By_Code(p_strCode);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveData(long p_lngAuto_ID, string p_strUpdated_By, string p_strUpdated_By_Function)
        {
            tbl_DM_Bill_DAL v_objDal = new tbl_DM_Bill_DAL();
            try
            {
                v_objDal.RemoveData(p_lngAuto_ID, p_strUpdated_By, p_strUpdated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
