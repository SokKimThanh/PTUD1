using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Seat_DTO
    {
        #region Fields
        private long? autoID;
        private string file;
        private int rank;
        private long theater_AutoID;
        private int deleted;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="autoID"></param>
        /// <param name="file"></param>
        /// <param name="rank"></param>
        /// <param name="theater_AutoID"></param>
        public tbl_DM_Seat_DTO(long? autoID, string file, int rank, long theater_AutoID, int deleted)
        {
            this.autoID = autoID;
            this.File = file;
            this.Rank = rank;
            this.Theater_AutoID = theater_AutoID;
            this.Deleted = deleted;
        }

        #region Properties
        public long? AutoID { get => autoID; }
        public string File { 
            get => file; 
            set 
            {
                if (value.Length != 1 && value.Length != 2)
                    throw new Exception("Lỗi tên file");
                else 
                    file = value;
            } 
        }
        public int Rank { get => rank; set => rank = value; }
        public long Theater_AutoID { get => theater_AutoID; set => theater_AutoID = value; }
        public int Deleted { get => deleted; set => deleted = value; }
        #endregion
    }
}
