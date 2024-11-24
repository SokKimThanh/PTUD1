using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Movie_BUS
    {
        tbl_DM_Movie_DAL data = new tbl_DM_Movie_DAL();
        /// <summary>
        /// Thêm mới Movie
        /// </summary>
        /// <param name="movie">tbl_DM_Movie_DTO</param>
        /// <returns></returns>
        public long Add(tbl_DM_Movie_DTO movie)
        {
            return data.Add(movie);
        }

        /// <summary>
        /// Xóa Movie
        /// </summary>
        /// <param name="id">MV_AutoID</param>
        /// <returns></returns>
        public bool Remove(long id)
        {
            return data.Remove(id);
        }

        /// <summary>
        /// Cập nhật Movie
        /// </summary>
        /// <param name="movie">tbl_DM_Movie_DTO</param>
        /// <returns></returns>
        public bool Update(tbl_DM_Movie_DTO movie)
        {
            return data.Update(movie);
        }

        /// <summary>
        /// Lấy danh sách Movie
        /// </summary>
        /// <returns>List<tbl_DM_Movie_DTO></returns>
        public List<tbl_DM_Movie_DTO> GetAll()
        {
            return data.GetAll();
        }

        /// <summary>
        /// Lấy danh sách phim theo thời lượng
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public List<tbl_DM_Movie_DTO> GetAll_ByDuration(int duration)
        {
            try
            {
                return data.GetAll_ByDuration(duration);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách phim theo ngày chiếu
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<tbl_DM_Movie_DTO> GetMovies_ByScheduleDate(DateTime date)
        {
            try
            {
                return data.GetMovies_ByScheduleDate(date);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tìm kiếm Movie theo ID
        /// </summary>
        /// <param name="id">dgv_selected_id, cboMovie_selected_id</param>
        /// <returns>tbl_DM_Movie_DTO</returns>
        public tbl_DM_Movie_DTO Find(long dgv_selected_id)
        {
            return data.Find(dgv_selected_id);
        }
        /// <summary>
        /// Danh sách combobox phim
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_Movie_DTO> GetCombobox()
        {
            return data.GetCombobox();
        }
    }
}
