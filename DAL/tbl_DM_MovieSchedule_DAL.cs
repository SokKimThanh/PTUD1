using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_MovieSchedule_DAL
    {
        private string person = "Admin";
        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void AddData(tbl_DM_MovieSchedule_DTO obj)
        {
            try
            {
                using(CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext())
                {
                    tbl_DM_MovieSchedule moviesche = new tbl_DM_MovieSchedule()
                    {
                        MS_MOVIE_AutoID = obj.Movie_AutoID,
                        MS_THEATER_AutoID = obj.Theater_AutoID,
                        MS_START = obj.StartDate,
                    };
                    moviesche.DELETED = 0;
                    moviesche.CREATED = DateTime.Now;
                    moviesche.CREATED_BY = person;
                    moviesche.CREATED_BY_FUNCTION = "Add full";
                    moviesche.UPDATED = DateTime.Now;
                    moviesche.UPDATED_BY = person;
                    moviesche.UPDATED_BY_FUNCTION = "Add full";

                    db.tbl_DM_MovieSchedules.InsertOnSubmit(moviesche);
                    db.SubmitChanges();

                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Hiển thị danh sách
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<tbl_DM_MovieSchedule_DTO> GetList()
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext())
                {
                    List<tbl_DM_MovieSchedule_DTO> list = new List<tbl_DM_MovieSchedule_DTO> ();
                    var list_Found = db.tbl_DM_MovieSchedules.Where(item => item.DELETED == 0);

                    foreach( tbl_DM_MovieSchedule item in list_Found)
                    {
                        list.Add(new tbl_DM_MovieSchedule_DTO(item.MS_AutoID, (long)item.MS_MOVIE_AutoID, (long)item.MS_THEATER_AutoID, item.MS_START, (int)item.DELETED));
                    }

                    return list;
                }
            }catch(Exception ex)
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
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext())
                {
                    tbl_DM_MovieSchedule moviesche = db.tbl_DM_MovieSchedules.SingleOrDefault(item => item.MS_AutoID == id);
                    moviesche.DELETED = 1;
                    moviesche.UPDATED = DateTime.Now;
                    moviesche.UPDATED_BY = person;
                    moviesche.UPDATED_BY_FUNCTION = "Delete";

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Cập nhật thông tin dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void UpdateData(tbl_DM_MovieSchedule_DTO obj)
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext())
                {
                    tbl_DM_MovieSchedule moviesche = db.tbl_DM_MovieSchedules.SingleOrDefault(item => item.MS_AutoID == obj.AutoID);
                    moviesche.MS_MOVIE_AutoID = obj.Movie_AutoID;
                    moviesche.MS_THEATER_AutoID = obj.Theater_AutoID;
                    moviesche.MS_START = obj.StartDate;
                    moviesche.DELETED = obj.Deleted;
                    moviesche.UPDATED = DateTime.Now;
                    moviesche.UPDATED_BY = person;
                    moviesche.UPDATED_BY_FUNCTION = "Update";

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
