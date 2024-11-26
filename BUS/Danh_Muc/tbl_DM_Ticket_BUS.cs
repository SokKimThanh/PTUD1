using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

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

        public List<tbl_DM_Ticket_DTO> List_Data_By_Bill_ID(long p_lngBill_ID)
        {
            try
            {
                return dal.List_Data_By_Bill_ID(p_lngBill_ID);
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_Ticket_DTO GetTicket_ByID(long id)
        {
            try
            {
                return dal.GetTicket_ByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveData(long ticketID)
        {
            try
            {
                dal.RemoveData(ticketID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveData_By_Bill_ID(long p_lngBill_ID, string p_strUpdated_By, string p_strUpdated_By_Function)
        {
            try
            {
                dal.RemoveData(p_lngBill_ID, p_strUpdated_By, p_strUpdated_By_Function);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddData(tbl_DM_Ticket_DTO p_objData)
        {
            try
            {
                dal.AddData(p_objData);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<TicketItem_DTO> GetTicket_ForShow(int deleted)
        {
            try
            {
                return dal.GetTicket_ForShow(deleted);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_Ticket_DTO GetTicket_BySeatName(string seatName, long movieScheduleID)
        {
            try
            {
                return dal.GetTicket_BySeatName(seatName, movieScheduleID);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
