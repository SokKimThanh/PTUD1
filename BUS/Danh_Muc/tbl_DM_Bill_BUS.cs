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
    }
}
