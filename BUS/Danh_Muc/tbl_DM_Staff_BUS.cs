using DAL;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Staff_BUS
    {
        public List<tbl_DM_Staff_DTO> ListData()
        {
            List<tbl_DM_Staff_DTO> arrRes = new List<tbl_DM_Staff_DTO>();
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            try
            {
                arrRes = objDAL.GetList();
            }
            catch (Exception)
            {
                throw;
            }

            return arrRes;
        }

        public void AddData(tbl_DM_Staff_DTO objNew)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            try
            {
                objDAL.AddData(objNew);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void UpdateData(tbl_DM_Staff_DTO obj)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            try
            {
                objDAL.UpdateData(obj);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void RemoveData(long id, string strUpdated_By, string strUpdated_By_Function)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            try
            {
                objDAL.RemoveData(id, strUpdated_By, strUpdated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void LoginProcess(tbl_DM_Staff_DTO objData)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            string strError = "";
            string strStep = "1";
            try
            {

                //Kiểm tra các trường thông tin nhập vào
                if (objData.ST_USERNAME == "")
                    strError += "Mã đăng nhập không được để trống.\n";

                if (objData.ST_PASSWORD == "")
                    strError += "Mật khẩu không được để trống.\n";

                if (strError != "")
                    throw new Exception(strError);

                strStep = "2";
                //Kiểm tra xem có user nào tồn tại với mã đăng nhập
                tbl_DM_Staff_DTO objUser = objDAL.GetDataByUserName(objData.ST_USERNAME);
                if (objUser == null)
                    throw new Exception("Mã đăng nhập không tồn tại.");

                strStep = "3";
                //Kiểm tra mật khẩu
                if (objUser.ST_PASSWORD.Trim() != CUtility.MD5_Encrypt(objData.ST_PASSWORD.Trim()))
                    throw new Exception("Mật khẩu không chính xác.");

                strStep = "4";
                //Kiểm tra xem nó đã được phân quyền chưa
                if (objUser.ST_LEVEL == (int)ELevel.None)
                    throw new Exception("Tài khoản này chưa được phân quyền.");

                //Nếu đã pass hết các trường hợp trên thì gán biến common
                CCommon.MaDangNhap = objUser.ST_USERNAME;
            }
            catch (Exception ex)
            {
                throw new Exception("Step: " + strStep + " , message: " + ex.Message);
            }

        }

        public int LoadLevelByMaDangNhap(string strMaDangNhap)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            int iRes = (int)ELevel.None;

            //Kiểm tra xem có user nào tồn tại với mã đăng nhập
            tbl_DM_Staff_DTO objUser = objDAL.GetDataByUserName(strMaDangNhap);
            if (objUser == null)
                throw new Exception("Mã đăng nhập không tồn tại.");

            iRes = objUser.ST_LEVEL;

            return iRes;
        }

        public string CheckLoginFileProcess(string strMaDangNhap, string strMatKhau)
        {
            tbl_DM_Staff_DAL objDAL = new tbl_DM_Staff_DAL();
            string strError = "";
            string strStep = "1";
            try
            {
                strMaDangNhap = strMaDangNhap.Trim();
                strMatKhau = strMatKhau.Trim();

                //Kiểm tra các trường thông tin nhập vào
                if (strMaDangNhap == "")
                    strError += "Mã đăng nhập không được để trống.\n";

                if (strMatKhau == "")
                    strError += "Mật khẩu không được để trống.\n";

                if (strError != "")
                    throw new Exception(strError);

                strStep = "2";
                //Kiểm tra xem có user nào tồn tại với mã đăng nhập
                tbl_DM_Staff_DTO objUser = null;
                foreach (tbl_DM_Staff_DTO objTemp in objDAL.GetList())
                {
                    if (CUtility.MD5_Encrypt(objTemp.ST_USERNAME.Trim()) == strMaDangNhap && objTemp.DELETED == 0)
                    {
                        objUser = objTemp;
                        break;
                    }
                }

                if (objUser == null)
                    throw new Exception("Mã đăng nhập không tồn tại.");

                strStep = "3";
                //Kiểm tra mật khẩu
                if (objUser.ST_PASSWORD.Trim() != strMatKhau)
                    throw new Exception("Mật khẩu không chính xác.");

                strStep = "4";
                //Kiểm tra xem nó đã được phân quyền chưa
                if (objUser.ST_LEVEL == (int)ELevel.None)
                    throw new Exception("Tài khoản này chưa được phân quyền.");

                return objUser.ST_USERNAME.Trim();
            }
            catch (Exception ex)
            {
                throw new Exception("Step: " + strStep + " , message: " + ex.Message);
            }

        }
    }
}
