using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Seat_BUS
    {
        private tbl_DM_Seat_DAL dal = new tbl_DM_Seat_DAL();

        public List<tbl_DM_Seat_DTO> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// Thêm số lượng lớn ghế vào phòng chiếu
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="couples"></param>
        /// <param name="theater_AutoID"></param>
        /// <returns></returns>
        public void AddData(int rows, int cols, int couples, long theater_AutoID)
        {
            try
            {
                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= cols; col++)
                    {
                        // Chuyển số dãy thành chữ
                        string file = Convert.ToChar(row + 64).ToString();
                        // Số cột là số thứ tự của ghế trên dãy
                        int rank = col;
                        tbl_DM_Seat_DTO item = new tbl_DM_Seat_DTO(null, file, rank, theater_AutoID, 0);
                        try
                        {
                            //Thêm ghế đơn vào danh sách
                            dal.AddData(item);
                        }
                        catch (Exception ex)
                        {
                            // Nếu ghế đã có trong danh sách 
                            if (ex.ToString().Contains("UNIQUE"))
                            {
                                tbl_DM_Seat_DTO item_Found = dal.FindSeat(file, rank, theater_AutoID);
                                // Tái kích hoạt ghế nếu ghế đang ẩn
                                if (item_Found.Deleted == 1)
                                {
                                    // Cập nhật trạng thái kích hoạt cho ghế vừa tìm thấy
                                    item_Found.Deleted = 0;
                                    dal.UpdateData(item_Found);
                                }
                            }
                        }
                    }
                }
                for (int couple = 1; couple <= couples; couple++)
                {
                    // Ghế đôi bắt đầu bằng ký tự CP
                    string file = "CP";
                    // Số ghế là số thứ tự
                    int rank = couple;
                    // Thêm ghế đôi vào danh sách
                    dal.AddData(new tbl_DM_Seat_DTO(null, file, rank, theater_AutoID, 0));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveData(int id)
        {
            dal.RemoveData(id);
        }
    }
}
