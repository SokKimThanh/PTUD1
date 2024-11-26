using System;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Ticket_DTO
    {
        private long autoID;
        private string seatName;
        private int status;
        private long movieScheID;
        private long? billID;
        private long staffID;
        private int deleted;
        private DateTime created;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;
        public tbl_DM_Ticket_DTO(long autoID, string seatName, int status, long movieScheID, long? billID, long staffID, int deleted, DateTime created)
        {
            this.autoID = autoID;
            this.SeatName = seatName;
            this.Status = status;
            this.MovieScheID = movieScheID;
            this.BillID = billID;
            this.StaffID = staffID;
            this.Deleted = deleted;
            this.Created = created;
        }

        public tbl_DM_Ticket_DTO()
        {

        }

        public long AutoID { get => autoID; set => autoID = value; }
        public string SeatName { get => seatName; set => seatName = value; }
        public long MovieScheID { get => movieScheID; set => movieScheID = value; }
        public long StaffID { get => staffID; set => staffID = value; }
        public int Deleted { get => deleted; set => deleted = value; }
        public long? BillID { get => billID; set => billID = value; }
        public DateTime Created { get => created; set => created = value; }
        public int Status { get => status; set => status = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value; }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value; }
        public DateTime? UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value; }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value; }
    }
}
