using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tbl_DM_Theater_BUS
    {
        private tbl_DM_Theater_DAL dal = new tbl_DM_Theater_DAL();
        public void AddData(tbl_DM_Theater_DTO obj)
        {
            try
            {
                dal.AddData(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách các phòng chiếu
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<tbl_DM_Theater_DTO> GetList()
        {
            try
            {
                return dal.GetList();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveData(int id)
        {
            try
            {
                dal.RemoveData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateData(tbl_DM_Theater_DTO obj)
        {
            try
            {
                dal.UpdateData(obj);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
