using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tbl_DM_MovieSchedule_BUS
    {
        private tbl_DM_MovieSchedule_DAL dal = new tbl_DM_MovieSchedule_DAL();

        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void AddData(tbl_DM_MovieSchedule_DTO obj)
        {
            try
            {
                dal.AddData(obj);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách hiển thị
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_MovieSchedule_DTO> GetList()
        {
            try
            {
                return dal.GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ẩn dữ liệu khỏi view
        /// </summary>
        /// <param name="id"></param>
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
        /// <summary>
        /// Cập nhật thông tin
        /// </summary>
        /// <param name="obj"></param>
        public void UpdateData(tbl_DM_MovieSchedule_DTO obj)
        {
            try
            {
                dal.UpdateData(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
