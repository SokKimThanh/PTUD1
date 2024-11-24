using DTO.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_DM_Bill_DTO
    {
        private long iBL_AutoID;
        private long iBL_STAFF_AutoID;
        private string m_strBL_Bill_Code;
        private double dblBL_Total_Price;      
        private int iDELETED;
        private DateTime? dtmCREATED;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;

        private List<tbl_DM_BillDetail_DTO> m_arrBill_Detail;
        private List<tbl_DM_Ticket_DTO> m_arrTiket;

        public tbl_DM_Bill_DTO()
        {

            iBL_AutoID = 0;
            m_strBL_Bill_Code = "";
            iBL_STAFF_AutoID = 0;
            dblBL_Total_Price = 0;
            dtmCREATED = null;
            strCREATED_BY = "";
            strCREATED_BY_FUNCTION = "";
            dtmUPDATED = null;
            strUPDATED_BY = "";
            strUPDATED_BY_FUNCTION = "";
            m_arrBill_Detail = new List<tbl_DM_BillDetail_DTO>();
            m_arrTiket = new List<tbl_DM_Ticket_DTO>();

        }


        public int DELETED { get => iDELETED; set => iDELETED = value; }
        public DateTime? CREATED { get => dtmCREATED; set => dtmCREATED = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value.Trim(); }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value.Trim(); }
        public DateTime? UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value.Trim(); }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value.Trim(); }
        public long BL_AutoID { get => iBL_AutoID; set => iBL_AutoID = value; }
        public long BL_STAFF_AutoID { get => iBL_STAFF_AutoID; set => iBL_STAFF_AutoID = value; }
        public string BL_Bill_Code { get => m_strBL_Bill_Code; set => m_strBL_Bill_Code = value.Trim(); }
        public double BL_Total_Price { get => dblBL_Total_Price; set => dblBL_Total_Price = value; }
        public List<tbl_DM_BillDetail_DTO> Bill_Detail { get => m_arrBill_Detail; set => m_arrBill_Detail = value; }
        public List<tbl_DM_Ticket_DTO> Tiket { get => m_arrTiket; set => m_arrTiket = value; }
    }
}
