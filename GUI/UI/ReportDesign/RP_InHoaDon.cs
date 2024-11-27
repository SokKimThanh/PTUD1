using BUS.Danh_Muc;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_InHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        private tbl_DM_Bill_BUS bill_Bus = new tbl_DM_Bill_BUS();
        public RP_InHoaDon()
        {
            InitializeComponent();
            txtNgayIn.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void BindParameter(string parameter)
        {
            try
            {
                prmBillAutoID.Value = parameter;
                prmBillAutoID.Visible = false;

                txtTinhTrang.Text = bill_Bus.Get_Data_By_ID(long.Parse(parameter)).BL_Trang_Thai_Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
