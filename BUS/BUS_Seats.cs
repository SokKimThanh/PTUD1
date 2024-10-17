using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Seats
    {
        private DAL_Seats dal = new DAL_Seats();
        public List<DTO_Seats> GetList()
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
                    string file = Convert.ToChar(row + 65).ToString();
                    int rank = col;
                    flg = dal.AddData(new DTO_Seats(null,file,rank, theater_AutoID));
                }
            }
            for(int couple = 1; couple <= couples; couple++)
            {
                string file = "CP";
                int rank = couple;
                flg = dal.AddData(new DTO_Seats(null, file, rank, theater_AutoID));
            }
            return flg;
        }

        public bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(DTO_Seats obj)
        {
            throw new NotImplementedException();
        }
    }
}
