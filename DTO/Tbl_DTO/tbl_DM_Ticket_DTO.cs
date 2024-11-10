using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Ticket_DTO
    {
        private long autoID;
        private string seatName;
        private long movieScheID;
        private long staffID;
        private int deleted;

        public tbl_DM_Ticket_DTO(long autoID, string seatName, long movieScheID, long staffID, int deleted)
        {
            this.autoID = autoID;
            this.SeatName = seatName;
            this.MovieScheID = movieScheID;
            this.StaffID = staffID;
            this.Deleted = deleted;
        }

        public tbl_DM_Ticket_DTO()
        {
            
        }

        public long AutoID { get => autoID;}
        public string SeatName { get => seatName; set => seatName = value; }
        public long MovieScheID { get => movieScheID; set => movieScheID = value; }
        public long StaffID { get => staffID; set => staffID = value; }
        public int Deleted { get => deleted; set => deleted = value; }
    }
}
