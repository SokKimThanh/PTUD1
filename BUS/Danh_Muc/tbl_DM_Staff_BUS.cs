
using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Staff_BUS
    {
        public List<tbl_DM_Staff_DTO> ListData()
        {
            List<tbl_DM_Staff_DTO> arrRes = new List<tbl_DM_Staff_DTO>();
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
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

        public void AddData(tbl_DM_Staff_DTO objNew)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            try
            {
                objDAL.AddData(objNew);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void UpdateData(tbl_DM_Staff_DTO obj)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
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
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
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
