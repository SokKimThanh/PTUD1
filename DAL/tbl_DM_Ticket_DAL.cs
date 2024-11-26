using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class tbl_DM_Ticket_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        /// <summary>
        /// Lấy danh sách các vé chưa xóa
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_Ticket_DTO> GetList()
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_Ticket_DTO> list = new List<tbl_DM_Ticket_DTO>();
                    var result = from tk in db.tbl_DM_Tickets
                                 where tk.DELETED == 0
                                 select tk;
                    foreach (var item in result)
                    {
                        list.Add(new tbl_DM_Ticket_DTO(item.TK_AutoID, item.TK_SEATNAME, item.TK_STATUS, item.TK_MOVIESCHEDULE_AutoID, item.TK_BILL_AutoID, item.TK_STAFF_AutoID, (int)item.DELETED, (DateTime)item.CREATED));
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbl_DM_Ticket_DTO> GetList_Deleted()
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_Ticket_DTO> list = new List<tbl_DM_Ticket_DTO>();
                    var result = from tk in db.tbl_DM_Tickets
                                 where tk.DELETED == 1
                                 select tk;
                    foreach (var item in result)
                    {
                        list.Add(new tbl_DM_Ticket_DTO(item.TK_AutoID, item.TK_SEATNAME, item.TK_STATUS, item.TK_MOVIESCHEDULE_AutoID, item.TK_BILL_AutoID, item.TK_STAFF_AutoID, (int)item.DELETED, (DateTime)item.CREATED));
                    }
                    return list;
                }
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
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    tbl_DM_Ticket foundTicket = db.tbl_DM_Tickets.SingleOrDefault(item => item.TK_AutoID == ticketID);
                    if (foundTicket != null)
                    {
                        foundTicket.DELETED = 1;
                        foundTicket.UPDATED = DateTime.Now;
                        foundTicket.UPDATED_BY = "Admin";
                        foundTicket.UPDATED_BY_FUNCTION = "delete by id";
                    }
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveData(long p_lngAuto_ID, string p_strUpdated_By, string p_strUpdated_By_Function)
        {
            try
            {
                using (CM_Cinema_DBDataContext DBDataContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_BillDetail> v_arrRes = DBDataContext.tbl_DM_BillDetails.Where(it => it.BD_AutoID == p_lngAuto_ID).ToList();
                    foreach (tbl_DM_BillDetail v_objRes in v_arrRes)
                    {
                        if (v_objRes != null)
                        {
                            v_objRes.DELETED = 1;
                            v_objRes.UPDATED = DateTime.Now;
                            v_objRes.UPDATED_BY = p_strUpdated_By;
                            v_objRes.UPDATED_BY_FUNCTION = p_strUpdated_By_Function;


                            DBDataContext.SubmitChanges();
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
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
                        list.Add(new tbl_DM_Ticket_DTO(item.TK_AutoID, item.TK_SEATNAME, item.TK_STATUS, item.TK_MOVIESCHEDULE_AutoID, item.TK_BILL_AutoID, item.TK_STAFF_AutoID, (int)item.DELETED, (DateTime)item.CREATED));
                    }
                    return list;
                }
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
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<tbl_DM_Ticket_DTO> list = new List<tbl_DM_Ticket_DTO>();
                    foreach (var item in db.tbl_DM_Tickets.Where(it => it.TK_BILL_AutoID == p_lngBill_ID))
                    {
                        tbl_DM_Ticket_DTO v_objRes = new tbl_DM_Ticket_DTO(item.TK_AutoID, item.TK_SEATNAME, item.TK_STATUS, item.TK_MOVIESCHEDULE_AutoID, item.TK_BILL_AutoID, item.TK_STAFF_AutoID, (int)item.DELETED, (DateTime)item.CREATED);
                        v_objRes.CREATED_BY = item.CREATED_BY;
                        v_objRes.UPDATED_BY = item.UPDATED_BY;
                        v_objRes.CREATED_BY_FUNCTION = item.CREATED_BY_FUNCTION;
                        v_objRes.UPDATED_BY_FUNCTION = item.UPDATED_BY_FUNCTION;

                        list.Add(v_objRes);
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
        public tbl_DM_Ticket_DTO GetTicket_ByID(long ticketID)
        {
            try
            {
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    tbl_DM_Ticket foundTicket = db.tbl_DM_Tickets.SingleOrDefault(item => item.TK_AutoID == ticketID);
                    if (foundTicket != null)
                    {
                        tbl_DM_Ticket_DTO result = new tbl_DM_Ticket_DTO(foundTicket.TK_AutoID, foundTicket.TK_SEATNAME, foundTicket.TK_STATUS, foundTicket.TK_MOVIESCHEDULE_AutoID, foundTicket.TK_BILL_AutoID, foundTicket.TK_STAFF_AutoID, (int)foundTicket.DELETED, (DateTime)foundTicket.CREATED);
                        return result;
                    }
                    else
                    {
                        throw new NullReferenceException("Không tìm thấy ID " + ticketID);
                    }
                }
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
                tbl_DM_Ticket v_objRes = new tbl_DM_Ticket();
                v_objRes.TK_STAFF_AutoID = p_objData.StaffID;
                v_objRes.TK_MOVIESCHEDULE_AutoID = p_objData.MovieScheID;
                v_objRes.TK_SEATNAME = p_objData.SeatName;
                v_objRes.TK_BILL_AutoID = p_objData.BillID;
                v_objRes.TK_STATUS = p_objData.Status;

                v_objRes.CREATED_BY_FUNCTION = p_objData.CREATED_BY_FUNCTION;
                v_objRes.UPDATED_BY_FUNCTION = p_objData.UPDATED_BY_FUNCTION;
                v_objRes.CREATED_BY = p_objData.CREATED_BY;
                v_objRes.UPDATED_BY = p_objData.UPDATED_BY;
                v_objRes.CREATED = DateTime.Now;
                v_objRes.UPDATED = DateTime.Now;
                v_objRes.DELETED = 0;

                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    db.tbl_DM_Tickets.InsertOnSubmit(v_objRes);
                    db.SubmitChanges();
                }

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
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    List<TicketItem_DTO> list = new List<TicketItem_DTO>();
                    var result = from tk in db.tbl_DM_Tickets
                                 join ms in db.tbl_DM_MovieSchedules on tk.TK_MOVIESCHEDULE_AutoID equals ms.MS_AutoID
                                 join mv in db.tbl_DM_Movies on ms.MS_MOVIE_AutoID equals mv.MV_AutoID
                                 join tt in db.tbl_DM_Theaters on ms.MS_THEATER_AutoID equals tt.TT_AutoID
                                 where tk.TK_STATUS == deleted
                                 select new
                                 {
                                     AutoID = tk.TK_AutoID,
                                     MovieName = mv.MV_NAME,
                                     TheaterName = tt.TT_NAME,
                                     SeatName = tk.TK_SEATNAME,
                                     Price = tk.TK_STATUS == 0 ? mv.MV_PRICE : mv.MV_PRICE / 2,
                                 };
                    foreach (var item in result)
                    {
                        list.Add(new TicketItem_DTO(item.AutoID, item.MovieName, item.SeatName, item.TheaterName, item.Price));
                    }
                    return list;
                }
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
                using (CM_Cinema_DBDataContext db = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    tbl_DM_Ticket foundTicket = db.tbl_DM_Tickets.SingleOrDefault(item => item.TK_SEATNAME.Trim() == seatName && item.TK_MOVIESCHEDULE_AutoID == movieScheduleID);
                    tbl_DM_Ticket_DTO result = null;
                    if (foundTicket != null)
                    {
                        result = new tbl_DM_Ticket_DTO(foundTicket.TK_AutoID, foundTicket.TK_SEATNAME, foundTicket.TK_STATUS, foundTicket.TK_MOVIESCHEDULE_AutoID, foundTicket.TK_BILL_AutoID, foundTicket.TK_STAFF_AutoID, (int)foundTicket.DELETED, (DateTime)foundTicket.CREATED);
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
