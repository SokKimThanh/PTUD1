using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_DM_MovieSchedule
    {
        #region Fields
        private long? autoID;
        private long movie_AutoID;
        private long theater_AutoID;
        private DateTime startDate;
        private int deleted;
        #endregion

        public tbl_DM_MovieSchedule(long? autoID, long movie_AutoID, long theater_AutoID, DateTime startDate, int deleted)
        {
            this.AutoID = autoID;
            this.Movie_AutoID = movie_AutoID;
            this.Theater_AutoID = theater_AutoID;
            this.StartDate = startDate;
            this.Deleted = deleted;
        }

        #region Properties
        public long? AutoID { get => autoID; set => autoID = value; }
        public long Movie_AutoID { get => movie_AutoID; set => movie_AutoID = value; }
        public long Theater_AutoID { get => theater_AutoID; set => theater_AutoID = value; }
        public DateTime StartDate { 
            get => startDate; 
            set{
                if(value < DateTime.Now)
                {
                    throw new Exception("Lỗi chọn ngày trong quá khứ");
                }
                else
                {
                    startDate = value;
                }
            }
        }
        public int Deleted { get => deleted; set => deleted = value; }
        #endregion
    }
}
