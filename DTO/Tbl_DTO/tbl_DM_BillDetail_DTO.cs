using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_DM_BillDetail_DTO
    {
        private long _BD_AutoID;
        private long _BD_BILL_AutoID;
        private long _BD_PRODUCT_AutoID;
        private double _BD_QUANTITY;
        private int iDELETED;
        private DateTime? dtmCREATED;
        private string strCREATED_BY;
        private string strCREATED_BY_FUNCTION;
        private DateTime? dtmUPDATED;
        private string strUPDATED_BY;
        private string strUPDATED_BY_FUNCTION;

        public tbl_DM_BillDetail_DTO(long bD_AutoID, long bD_BILL_AutoID, long bD_PRODUCT_AutoID, double bD_QUANTITY, int dELETED)
        {
            BD_AutoID = bD_AutoID;
            BD_BILL_AutoID = bD_BILL_AutoID;
            BD_PRODUCT_AutoID = bD_PRODUCT_AutoID;
            BD_QUANTITY = bD_QUANTITY;
            DELETED = dELETED;
        }

        public tbl_DM_BillDetail_DTO()
        {
            BD_AutoID = 0;
            BD_BILL_AutoID = 0;
            BD_PRODUCT_AutoID = 0;
            BD_QUANTITY = 0;
            DELETED = 0;
            dtmCREATED = null;
            strCREATED_BY = "";
            strCREATED_BY_FUNCTION = "";
            dtmUPDATED = null;
            strUPDATED_BY = "";
            strUPDATED_BY_FUNCTION = "";
        }

        public long BD_AutoID { get => _BD_AutoID; set => _BD_AutoID = value; }
        public long BD_BILL_AutoID { get => _BD_BILL_AutoID; set => _BD_BILL_AutoID = value; }
        public long BD_PRODUCT_AutoID { get => _BD_PRODUCT_AutoID; set => _BD_PRODUCT_AutoID = value; }
        public double BD_QUANTITY { get => _BD_QUANTITY; set => _BD_QUANTITY = value; }
        public int DELETED { get => iDELETED; set => iDELETED = value; }
        public DateTime? CREATED { get => dtmCREATED; set => dtmCREATED = value; }
        public string CREATED_BY { get => strCREATED_BY; set => strCREATED_BY = value; }
        public string CREATED_BY_FUNCTION { get => strCREATED_BY_FUNCTION; set => strCREATED_BY_FUNCTION = value; }
        public DateTime?UPDATED { get => dtmUPDATED; set => dtmUPDATED = value; }
        public string UPDATED_BY { get => strUPDATED_BY; set => strUPDATED_BY = value; }
        public string UPDATED_BY_FUNCTION { get => strUPDATED_BY_FUNCTION; set => strUPDATED_BY_FUNCTION = value; }
    }
}
