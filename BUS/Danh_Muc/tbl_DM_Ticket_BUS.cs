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
        public List<tbl_DM_Ticket_DTO> GetList()
        {
            try
            {
                return dal.GetList();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_Ticket_DTO GetTicket_ByID(long id)
        {
            try
            {
                return dal.GetTicket_ByID(id);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
