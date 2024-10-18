using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tbl_DM_Seat_BUS
    {
        private tbl_DM_Seat_DAL dal = new tbl_DM_Seat_DAL();

        public List<tbl_DM_Seat_DTO> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Thêm số lượng lớn ghế vào phòng chiếu
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="couples"></param>
        /// <param name="theater_AutoID"></param>
        /// <returns></returns>
        public bool AddData(int rows, int cols, int couples, int theater_AutoID)
        {
            bool flg = false;

            for(int row = 1; row <= cols; row++)
            {
                for(int col = 1; col <= cols; col++)
                {
                    // Chuyển số dãy thành chữ
                    string file = Convert.ToChar(row + 65).ToString();
                    // Số cột là số thứ tự của ghế trên dãy
                    int rank = col;
                    //Thêm ghế đơn vào danh sách
                    flg = dal.AddData(new tbl_DM_Seat_DTO(null,file,rank, theater_AutoID));
                }
            }
            for(int couple = 1; couple <= couples; couple++)
            {
                // Ghế đôi bắt đầu bằng ký tự CP
                string file = "CP";
                // Số ghế là số thứ tự
                int rank = couple;
                // Thêm ghế đôi vào danh sách
                flg = dal.AddData(new tbl_DM_Seat_DTO(null, file, rank, theater_AutoID));
            }
            return flg;
        }

        public bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(tbl_DM_Seat_DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
