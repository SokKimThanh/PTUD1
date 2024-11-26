using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Shift_BUS
    {
        public List<tbl_DM_Shift_DTO> ListData()
        {
            List<tbl_DM_Shift_DTO> arrRes = new List<tbl_DM_Shift_DTO>();
            tbl_DM_Shift_DAL objDAL = new tbl_DM_Shift_DAL();
            try
            {
                arrRes = objDAL.GetList();
            }
            catch (Exception)
            {
                throw;
            }

            return arrRes;
        }

        public void AddData(tbl_DM_Shift_DTO objNew)
        {
            tbl_DM_Shift_DAL objDAL = new tbl_DM_Shift_DAL();
            try
            {
                objDAL.AddData(objNew);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void UpdateData(tbl_DM_Shift_DTO obj)
        {
            tbl_DM_Shift_DAL objDAL = new tbl_DM_Shift_DAL();
            try
            {
                objDAL.UpdateData(obj);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_Shift_DAL objDAL = new tbl_DM_Shift_DAL();
            try
            {
                objDAL.RemoveData(id, strUpdated_By, strUpdated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
