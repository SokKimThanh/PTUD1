using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_Ticket_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;
        public void AddData(tbl_DM_Ticket_DTO obj)
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_DM_Ticket_DTO> GetList()
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_Ticket_DTO> list = new List<tbl_DM_Ticket_DTO>();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveData(int id)
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_DM_Ticket_DTO> GetList_ByMovieSchedule(long moviesSheduleID)
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_Ticket_DTO> list = new List<tbl_DM_Ticket_DTO>();
                    var result = from tk in db.tbl_DM_Tickets
                                 where tk.TK_MOVIESCHEDULE_AutoID == moviesSheduleID
                                 select tk;
                    foreach (var item in result)
                    {
                        list.Add(new tbl_DM_Ticket_DTO(item.TK_AutoID, item.TK_SEATNAME, item.TK_MOVIESCHEDULE_AutoID, item.TK_STAFF_AutoID, (int)item.DELETED));
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SeatExist_ByMovieSchedule(string seatName, long movieScheduleID)
        {
            using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
            {
                return db.tbl_DM_Tickets.SingleOrDefault(item => item.TK_SEATNAME == seatName && item.TK_MOVIESCHEDULE_AutoID == movieScheduleID) != null;
            }
        }
    }
}
