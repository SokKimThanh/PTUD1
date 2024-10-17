using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Seats : BasicMethods<DTO_Seats>
    {
        private CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext();

        /// <summary>
        /// Lấy danh sách số ghế của các rạp phim
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override List<DTO_Seats> GetList()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Thêm 1 ghế vào danh sách ghế
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool AddData(DTO_Seats obj)
        {
            try
            {
                bool flg = false;
                tbl_DM_Seat seat = new tbl_DM_Seat()
                {
                    SE_FILE = obj.File,
                    SE_RANK = obj.Rank,
                    SE_THEATER_AutoID = obj.Theater_AutoID
                };
                db.tbl_DM_Seats.InsertOnSubmit(seat);
                db.SubmitChanges();

                flg = true;
                return flg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sửa thông tin ghế
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool UpdateData(DTO_Seats obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Xóa 1 ghế khỏi view
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }
    }
}
