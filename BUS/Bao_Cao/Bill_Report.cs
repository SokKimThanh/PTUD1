using BUS.Danh_Muc;
using DevExpress.DataAccess.ObjectBinding;
using DTO.tbl_DTO;

namespace BUS.Bao_Cao
{
    public class Bill_Report
    {
        private string m_strBill_Code = "";

        [HighlightedMember]
        public Bill_Report(string p_strBill_Code)
        {
            m_strBill_Code = p_strBill_Code;
        }

        [HighlightedMember]
        public tbl_DM_Bill_DTO Get_Bill(int recordCount)
        {
            tbl_DM_Bill_BUS v_objBill_BUS = new tbl_DM_Bill_BUS();

            // Lấy dữ liệu hóa đơn theo mã
            tbl_DM_Bill_DTO v_objRes = v_objBill_BUS.Get_Data_By_Code(m_strBill_Code);

            if (v_objRes != null)
            {
                tbl_DM_BillDetail_BUS v_objBill_Detail_BUS = new tbl_DM_BillDetail_BUS();
                tbl_DM_Ticket_BUS v_objTiket_BUS = new tbl_DM_Ticket_BUS();

                v_objRes.Bill_Detail = v_objBill_Detail_BUS.List_Data_By_Bill_ID(v_objRes.BL_STAFF_AutoID);
                v_objRes.Tiket = v_objTiket_BUS.List_Data_By_Bill_ID(v_objRes.BL_STAFF_AutoID);
            }

            return v_objRes;
        }
    }
}
