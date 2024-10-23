using DTO.Custom;
using System;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Staff_DTO
    {
        private long iST_AutoID;
        private string strST_USERNAME;
        private string strST_PASSWORD;
        private string strST_NAME;
        private string strST_PHONE;
        private string strST_CIC;
        private string strST_NOTE;
        private int iST_LEVEL;
        private int iDELETED;
        private DateTime? dtmCREATED;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;

        public tbl_DM_Staff_DTO()
        {
            iST_AutoID = 0;
            strST_USERNAME = "";
            strST_PASSWORD = "";
            strST_NAME = "";
            strST_PHONE = "";
            strST_CIC = "";
            strST_NOTE = "";
            iST_LEVEL = (int)ELevel.None;
            iDELETED = 0;
            dtmCREATED = null;
            strCREATED_BY = "";
            strCREATED_BY_FUNCTION = "";
            dtmUPDATED = null;
            strUPDATED_BY = "";
            strUPDATED_BY_FUNCTION = "";
        }

        public long ST_AutoID { get => iST_AutoID; set => iST_AutoID = value; }
        public string ST_USERNAME { get => strST_USERNAME; set => strST_USERNAME = value.Trim(); }
        public string ST_PASSWORD { get => strST_PASSWORD; set => strST_PASSWORD = value.Trim(); }
        public string ST_NAME { get => strST_NAME; set => strST_NAME = value.Trim(); }
        public string ST_PHONE { get => strST_PHONE; set => strST_PHONE = value.Trim(); }
        public string ST_CIC { get => strST_CIC; set => strST_CIC = value.Trim(); }
        public string ST_NOTE { get => strST_NOTE; set => strST_NOTE = value.Trim(); }
        public int ST_LEVEL { get => iST_LEVEL; set => iST_LEVEL = value; }
        public int DELETED { get => iDELETED; set => iDELETED = value; }
        public DateTime? CREATED { get => dtmCREATED; set => dtmCREATED = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value.Trim(); }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value.Trim(); }
        public DateTime? UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value.Trim(); }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value.Trim(); }

        public string ST_LEVELText
        {
            get
            {
                switch (ST_LEVEL)
                {
                    case (int)ELevel.None:
                        return "None";
                    case (int)ELevel.Staff:
                        return "Staff";
                    case (int)ELevel.Manager:
                        return "Manager";
                    case (int)ELevel.Admin:
                        return "Admin";
                    default:
                        return "";
                }

            }
        }
    }
}
