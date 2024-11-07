using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_Staff_DAL : BasicMethods<tbl_DM_Staff_DTO>
    {

        public override void AddData(tbl_DM_Staff_DTO obj)
        {
            if (obj.ST_USERNAME.Trim() == "")
                throw new Exception("Mã đăng nhập không được rỗng.");

            if (obj.ST_PASSWORD.Trim() == "")
                throw new Exception("Mật khẩu không được rỗng.");

            //Kiểm tra xem mã đăng nhập có tồn tại
            tbl_DM_Staff objCheck = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_USERNAME.Trim() == obj.ST_USERNAME.Trim() && it.DELETED == 0);
            if (objCheck != null)
                throw new Exception("Mã đăng nhập đã tồn tại");

            tbl_DM_Staff objNew = new tbl_DM_Staff();
            CUtility.Clone_Entity(obj, objNew);

            DBDataContext.tbl_DM_Staffs.InsertOnSubmit(objNew);
            DBDataContext.SubmitChanges();
        }

        public override List<tbl_DM_Staff_DTO> GetList()
        {
            List<tbl_DM_Staff_DTO> arrRes = new List<tbl_DM_Staff_DTO>();
            List<tbl_DM_Staff> arrDB = DBDataContext.tbl_DM_Staffs.Where(it => it.DELETED == 0).OrderByDescending(it => it.ST_AutoID).ToList();

            foreach (tbl_DM_Staff objDB in arrDB)
            {
                tbl_DM_Staff_DTO objNew = new tbl_DM_Staff_DTO();
                CUtility.Clone_Entity(objDB, objNew);
                arrRes.Add(objNew);
            }

            return arrRes;
        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_Staff objRes = DBDataContext.tbl_DM_Staffs.SingleOrDefault(it => it.ST_AutoID == id);

            if (objRes != null)
            {
                objRes.DELETED = 1;
                objRes.UPDATED = DateTime.Now;
                objRes.UPDATED_BY = strUpdated_By;
                objRes.UPDATED_BY_FUNCTION = strUpdated_By_Function;
                DBDataContext.SubmitChanges();
            }
        }

        public override void UpdateData(tbl_DM_Staff_DTO obj)
        {
            if (obj.ST_USERNAME.Trim() == "")
                throw new Exception("Mã đăng nhập không được rỗng.");

            if (obj.ST_PASSWORD.Trim() == "")
                throw new Exception("Mật khẩu không được rỗng.");

            //Kiểm tra xem mã đăng nhập có tồn tại
            tbl_DM_Staff objCheck = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_AutoID != obj.ST_AutoID &&
                                        it.ST_USERNAME.Trim() == obj.ST_USERNAME.Trim() && it.DELETED == 0);

            if (objCheck != null)
                throw new Exception("Mã đăng nhập đã tồn tại");

            tbl_DM_Staff objRes = DBDataContext.tbl_DM_Staffs.SingleOrDefault(it => it.ST_AutoID == obj.ST_AutoID);

            if (objRes != null)
            {
                objRes.ST_USERNAME = obj.ST_USERNAME.Trim();
                objRes.ST_PASSWORD = obj.ST_PASSWORD.Trim();
                objRes.ST_NAME = obj.ST_NAME.Trim();
                objRes.ST_PHONE = obj.ST_PHONE.Trim();
                objRes.ST_CIC = obj.ST_CIC.Trim();
                objRes.ST_NOTE = obj.ST_NOTE.Trim();
                objRes.ST_LEVEL = obj.ST_LEVEL;
                objRes.UPDATED = obj.UPDATED;
                objRes.UPDATED_BY = obj.UPDATED_BY.Trim();
                objRes.UPDATED_BY_FUNCTION = obj.UPDATED_BY_FUNCTION.Trim();

                DBDataContext.SubmitChanges();
            }

        }

        public tbl_DM_Staff_DTO GetDataByUserName(string strUserName)
        {
            tbl_DM_Staff objDB = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_USERNAME.Trim() == strUserName.Trim() && it.DELETED == 0);
            tbl_DM_Staff_DTO objRes = null;
            if (objDB != null)
            {
                objRes = new tbl_DM_Staff_DTO();
                CUtility.Clone_Entity(objDB, objRes);
            }

            return objRes;
        }

        public override void RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public tbl_DM_Staff_DTO GetStaff_ByID(int id)
        {
            try
            {
                tbl_DM_Staff objDB = DBDataContext.tbl_DM_Staffs.FirstOrDefault(it => it.ST_AutoID == id && it.DELETED == 0);
                tbl_DM_Staff_DTO objRes = null;
                if (objDB != null)
                {
                    objRes = new tbl_DM_Staff_DTO();
                    CUtility.Clone_Entity(objDB, objRes);
                }

                return objRes;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
