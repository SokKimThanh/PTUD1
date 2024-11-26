using System;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Shift_DTO
    {
        private long iSF_AutoID;
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


        public tbl_DM_Shift_DTO()
        {
            iSF_AutoID = 0;
            strSF_NAME = "";
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

        public long SF_AutoID { get => iSF_AutoID; set => iSF_AutoID = value; }
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
    }
}
