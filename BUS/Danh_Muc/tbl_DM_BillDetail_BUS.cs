using DAL;
using DTO.tbl_DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_BillDetail_BUS
    {
        public void AddData(tbl_DM_BillDetail_DTO objNew)
        {
            tbl_DM_BillDetail_DAL objDAL = new tbl_DM_BillDetail_DAL();
            try
            {
                objDAL.AddData(objNew);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<tbl_DM_BillDetail_DTO> List_Data()
        {
            tbl_DM_BillDetail_DAL v_objDal = new tbl_DM_BillDetail_DAL();
            try
            {
                return v_objDal.GetList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<tbl_DM_BillDetail_DTO> List_Data_By_Bill_ID(long p_lngBill_ID)
        {
            tbl_DM_BillDetail_DAL v_objDal = new tbl_DM_BillDetail_DAL();
            try
            {
                return v_objDal.GetList_By_Bill_ID(p_lngBill_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
