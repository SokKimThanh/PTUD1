using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class tbl_DM_StaffSchedule_DAL : BasicMethods<tbl_DM_StaffSchedule_DTO>
    {
        public override void AddData(tbl_DM_StaffSchedule_DTO obj)
        {
            if (obj.SS_STAFF_AutoID == 0)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (obj.SS_SHIFT_AutoID == 0)
                throw new Exception("Vui lòng chọn ca làm.");

            //get các obj ra
            tbl_DM_Staff objStaff = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_AutoID == obj.SS_STAFF_AutoID);
            if (objStaff == null)
                throw new Exception("Mã đăng nhập không tồn tại");

            tbl_DM_Shift objShift = DBDataContext.tbl_DM_Shifts.FirstOrDefault(it => it.SF_AutoID == obj.SS_SHIFT_AutoID);
            if (objShift == null)
                throw new Exception("Tên ca làm không tồn tại");

            tbl_DM_StaffSchedule objCheck = DBDataContext.tbl_DM_StaffSchedules.FirstOrDefault(
                it => it.SS_SHIFT_AutoID == objShift.SF_AutoID
                && it.SS_STAFF_AutoID == objStaff.ST_AutoID
                && it.DELETED == 0
                );

            if (objCheck != null)
                throw new Exception("Nhân viên đã khai báo ca làm này. ");

            tbl_DM_StaffSchedule objNew = new tbl_DM_StaffSchedule();
            objNew.tbl_DM_Staff = objStaff;
            objNew.tbl_DM_Shift = objShift;

            CUtility.Clone_Entity(obj, objNew);

            DBDataContext.tbl_DM_StaffSchedules.InsertOnSubmit(objNew);
            DBDataContext.SubmitChanges();
        }

        public override List<tbl_DM_StaffSchedule_DTO> GetList()
        {
            List<tbl_DM_StaffSchedule_DTO> arrRes = new List<tbl_DM_StaffSchedule_DTO>();
            List<tbl_DM_StaffSchedule> arrDB = DBDataContext.tbl_DM_StaffSchedules.Where(it => it.DELETED == 0).OrderByDescending(it => it.SS_AutoID).ToList();

            foreach (tbl_DM_StaffSchedule objDB in arrDB)
            {
                tbl_DM_StaffSchedule_DTO objNew = new tbl_DM_StaffSchedule_DTO();
                CUtility.Clone_Entity(objDB, objNew);
                objNew.ST_USERNAME = objDB.tbl_DM_Staff.ST_USERNAME;
                objNew.ST_NAME = objDB.tbl_DM_Staff.ST_NAME;

                objNew.SF_NAME = objDB.tbl_DM_Shift.SF_NAME;
                objNew.SF_START = objDB.tbl_DM_Shift.SF_START;
                objNew.SF_END = objDB.tbl_DM_Shift.SF_END;

                arrRes.Add(objNew);
            }

            return arrRes;
        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_StaffSchedule objRes = DBDataContext.tbl_DM_StaffSchedules.SingleOrDefault(it => it.SS_AutoID == id);

            if (objRes != null)
            {
                objRes.DELETED = 1;
                objRes.UPDATED = DateTime.Now;
                objRes.UPDATED_BY = strUpdated_By;
                objRes.UPDATED_BY_FUNCTION = strUpdated_By_Function;
                DBDataContext.SubmitChanges();
            }
        }

        public override void UpdateData(tbl_DM_StaffSchedule_DTO obj)
        {

            if (obj.SS_STAFF_AutoID == 0)
                throw new Exception("Vui lòng chọn nhân viên.");

            if (obj.SS_SHIFT_AutoID == 0)
                throw new Exception("Vui lòng chọn ca làm.");

            //get các obj ra
            tbl_DM_Staff objStaff = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_AutoID == obj.SS_STAFF_AutoID);
            if (objStaff == null)
                throw new Exception("Mã đăng nhập không tồn tại");

            tbl_DM_Shift objShift = DBDataContext.tbl_DM_Shifts.FirstOrDefault(it => it.SF_AutoID == obj.SS_SHIFT_AutoID);
            if (objShift == null)
                throw new Exception("Tên ca làm không tồn tại");

            tbl_DM_StaffSchedule objCheck = DBDataContext.tbl_DM_StaffSchedules.FirstOrDefault(
                it => it.SS_SHIFT_AutoID == objShift.SF_AutoID
                && it.SS_STAFF_AutoID == objStaff.ST_AutoID
                && it.DELETED == 0
                && it.SS_AutoID != obj.SS_AutoID
                );

            if (objCheck != null)
                throw new Exception("Nhân viên đã khai báo ca làm này. ");


            tbl_DM_StaffSchedule objRes = DBDataContext.tbl_DM_StaffSchedules.SingleOrDefault(it => it.SS_AutoID == obj.SS_AutoID);

            if (objRes != null)
            {
                objRes.tbl_DM_Shift = objShift;
                objRes.tbl_DM_Staff = objStaff;

                objRes.UPDATED = obj.UPDATED;
                objRes.UPDATED_BY = obj.UPDATED_BY.Trim();
                objRes.UPDATED_BY_FUNCTION = obj.UPDATED_BY_FUNCTION.Trim();

                DBDataContext.SubmitChanges();
            }

        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }
    }
}
