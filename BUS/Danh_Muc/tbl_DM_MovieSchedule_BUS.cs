using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_MovieSchedule_BUS
    {
        private tbl_DM_MovieSchedule_DAL dal = new tbl_DM_MovieSchedule_DAL();

        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void AddData(long movie_AutoID, long theater_AutoID, DateTime startDate, DateTime endDate)
        {
            try
            {
                dal.AddData(new tbl_DM_MovieSchedule_DTO(null, movie_AutoID, null, theater_AutoID, null, startDate, endDate, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách hiển thị
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_MovieSchedule_DTO> GetList(int deleted)
        {
            try
            {
                return dal.GetList(deleted);
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
        public void UpdateData(long autoID, long movie_AutoID, long theater_AutoID, DateTime startDate, DateTime endDate, int delete)
        {
            try
            {
                dal.UpdateData(new tbl_DM_MovieSchedule_DTO(autoID, movie_AutoID, null, theater_AutoID, null, startDate, endDate, delete));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tìm suất chiếu cuối của phòng chiếu đang chọn
        /// </summary>
        /// <param name="theaterID"></param>
        /// <returns></returns>
        public tbl_DM_MovieSchedule_DTO GetLastMovieSchedule_ByTheater(long theaterID)
        {
            try
            {
                tbl_DM_MovieSchedule_DTO foundMovieSchedule = dal.GetLastMovieSchedule_ByTheater(theaterID);
                return foundMovieSchedule;
                //if(foundMovieSchedule != null)
                //{
                //    return foundMovieSchedule;
                //}
                //else
                //{
                //    throw new NullReferenceException("Không tìm thấy ca");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_MovieSchedule_DTO GetLastMovieSchedule_ByID(long id)
        {
            try
            {
                return dal.GetLastMovieSchedule_ByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_MovieSchedule_DTO GetLastMovieSchedule_ByTheaterandMovie(long theaterID, long movieID)
        {
            try
            {
                tbl_DM_MovieSchedule_DTO foundMovieSchedule = dal.GetLastMovieSchedule_ByTheaterandMovie(theaterID, movieID);
                return foundMovieSchedule;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_DM_MovieSchedule_DTO> GetMovieSchedule_ByMovieDate(long movieID, DateTime date)
        {
            try
            {
                return dal.GetMovieSchedule_ByMovieDate(movieID, date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_DM_MovieSchedule_DTO> GetMovieSchedule_ByTheater(long theaterID)
        {
            try
            {
                return dal.GetMovieSchedule_ByTheater(theaterID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool IsBookedSchedule(long id)
        {
            try
            {
                return dal.IsBookedSchedule(id);
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
