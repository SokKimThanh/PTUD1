using System;

namespace DTO.tbl_DTO
{
    public class tbl_DM_StaffSchedule_DTO
    {
        private long iSS_AutoID;
        private long iSS_STAFF_AutoID;
        private long iSS_SHIFT_AutoID;

        private string strST_USERNAME;
        private string strST_NAME;

        private string strSF_NAME;
        private DateTime dtmSF_START;
        private DateTime dtmSF_END;

        private int iDELETED;
        private DateTime? dtmCREATED;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;

        public tbl_DM_StaffSchedule_DTO()
        {
            iSS_AutoID = 0;
            strST_USERNAME = "";
            strSF_NAME = "";
            strST_NAME = "";
            dtmSF_START = DateTime.Now;
            dtmSF_END = DateTime.Now;
            iDELETED = 0;
            dtmCREATED = null;
            strCREATED_BY = "";
            strCREATED_BY_FUNCTION = "";
            dtmUPDATED = null;
            strUPDATED_BY = "";
            strUPDATED_BY_FUNCTION = "";
        }

        public long SS_AutoID { get => iSS_AutoID; set => iSS_AutoID = value; }
        public string ST_USERNAME { get => strST_USERNAME; set => strST_USERNAME = value.Trim(); }
        public string ST_NAME { get => strST_NAME; set => strST_NAME = value.Trim(); }

        public string SF_NAME { get => strSF_NAME; set => strSF_NAME = value.Trim(); }
        public DateTime SF_START { get => dtmSF_START; set => dtmSF_START = value; }
        public DateTime SF_END { get => dtmSF_END; set => dtmSF_END = value; }
        public int DELETED { get => iDELETED; set => iDELETED = value; }
        public DateTime? CREATED { get => dtmCREATED; set => dtmCREATED = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value.Trim(); }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value.Trim(); }
        public DateTime? UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value.Trim(); }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value.Trim(); }
        public long SS_STAFF_AutoID { get => iSS_STAFF_AutoID; set => iSS_STAFF_AutoID = value; }
        public long SS_SHIFT_AutoID { get => iSS_SHIFT_AutoID; set => iSS_SHIFT_AutoID = value; }
    }
}
