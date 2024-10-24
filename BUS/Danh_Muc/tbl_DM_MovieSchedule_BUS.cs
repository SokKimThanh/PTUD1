using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_MovieSchedule_BUS
    {
        private tbl_DM_MovieSchedule_DAL dal = new tbl_DM_MovieSchedule_DAL();

        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void AddData(long movie_AutoID, long theater_AutoID, DateTime startDate)
        {
            try
            {
                dal.AddData(new tbl_DM_MovieSchedule_DTO(null,movie_AutoID,null,theater_AutoID,null,startDate,0));
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
        public void RemoveData(long id)
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
        public void UpdateData(long autoID, long movie_AutoID, long theater_AutoID, DateTime startDate, int delete)
        {
            try
            {
                dal.UpdateData(new tbl_DM_MovieSchedule_DTO(autoID, movie_AutoID, null, theater_AutoID, null, startDate, delete));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
