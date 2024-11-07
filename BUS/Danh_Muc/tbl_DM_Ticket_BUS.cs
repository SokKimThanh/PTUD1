using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Ticket_BUS
    {
        private tbl_DM_Ticket_DAL dal = new tbl_DM_Ticket_DAL();
        public List<tbl_DM_Ticket_DTO> GetList_ByMovieSchedule(long moviesSheduleID)
        {
            try
            {
                return dal.GetList_ByMovieSchedule(moviesSheduleID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SeatExist_ByMovieSchedule(string seatName, long movieScheduleID)
        {
            return dal.SeatExist_ByMovieSchedule(seatName, movieScheduleID);
        }
    }
}
