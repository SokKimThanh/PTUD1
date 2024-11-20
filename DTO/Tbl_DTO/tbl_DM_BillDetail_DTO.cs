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
        private int _BD_QUANTITY;
        private long _DELETED;

        public tbl_DM_BillDetail_DTO(long bD_AutoID, long bD_BILL_AutoID, long bD_PRODUCT_AutoID, int bD_QUANTITY, long dELETED)
        {
            BD_AutoID = bD_AutoID;
            BD_BILL_AutoID = bD_BILL_AutoID;
            BD_PRODUCT_AutoID = bD_PRODUCT_AutoID;
            BD_QUANTITY = bD_QUANTITY;
            DELETED = dELETED;
        }

        public long BD_AutoID { get => _BD_AutoID; set => _BD_AutoID = value; }
        public long BD_BILL_AutoID { get => _BD_BILL_AutoID; set => _BD_BILL_AutoID = value; }
        public long BD_PRODUCT_AutoID { get => _BD_PRODUCT_AutoID; set => _BD_PRODUCT_AutoID = value; }
        public int BD_QUANTITY { get => _BD_QUANTITY; set => _BD_QUANTITY = value; }
        public long DELETED { get => _DELETED; set => _DELETED = value; }
    }
}
