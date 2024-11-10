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
        private long iBL_PRODUCT_AutoID;
        private long iBL_STAFF_AutoID;
        private double dblBL_QUANTITY;
        private double dblBL_PRICE;      
        private int iDELETED;
        private DateTime? dtmCREATED;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;

        private string strBL_PRODUCT_NAME;
        private string strBL_NAME;

        public tbl_DM_Bill_DTO()
        {

            iBL_AutoID = 0;
            iBL_PRODUCT_AutoID = 0;
            iBL_STAFF_AutoID = 0;
            dblBL_QUANTITY = 0;
            dblBL_PRICE = 0;
            dtmCREATED = null;
            strCREATED_BY = "";
            strCREATED_BY_FUNCTION = "";
            dtmUPDATED = null;
            strUPDATED_BY = "";
            strUPDATED_BY_FUNCTION = "";

            strBL_PRODUCT_NAME = "";
            strBL_NAME = "";
        }

    
        public int DELETED { get => iDELETED; set => iDELETED = value; }
        public DateTime? CREATED { get => dtmCREATED; set => dtmCREATED = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value.Trim(); }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value.Trim(); }
        public DateTime? UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value.Trim(); }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value.Trim(); }
        public long BL_AutoID { get => iBL_AutoID; set => iBL_AutoID = value; }
        public long BL_PRODUCT_AutoID { get => iBL_PRODUCT_AutoID; set => iBL_PRODUCT_AutoID = value; }
        public long BL_STAFF_AutoID { get => iBL_STAFF_AutoID; set => iBL_STAFF_AutoID = value; }
        public double BL_QUANTITY { get => dblBL_QUANTITY; set => dblBL_QUANTITY = value; }
        public double BL_PRICE { get => dblBL_PRICE; set => dblBL_PRICE = value; }
        public string BL_PRODUCT_NAME { get => strBL_PRODUCT_NAME; set => strBL_PRODUCT_NAME = value.Trim(); }
        public string BL_NAME { get => strBL_NAME; set => strBL_NAME = value.Trim(); }
    }
}
