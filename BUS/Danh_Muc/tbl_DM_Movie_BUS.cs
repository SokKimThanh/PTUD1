using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
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
