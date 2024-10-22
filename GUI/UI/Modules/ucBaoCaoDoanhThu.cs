using BUS.Bao_Cao;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoDoanhThu : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        public ucBaoCaoDoanhThu()
        {
            InitializeComponent();
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;
        }

        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // hiển thị danh sách báo cáo
            if (rptViewReport.SelectedIndex == 0)
            {
                // tổng quan
                dgv.DataSource = data.GetAllSalesReport(DateTime.Parse(txtStartDate.Text.Trim()), DateTime.Parse(txtEndDate.Text.Trim()));
            }
            else
            {
                // chi tiết 
                dgv.DataSource = data.GetDetailSaleReport(DateTime.Parse(txtStartDate.Text.Trim()), DateTime.Parse(txtEndDate.Text.Trim()));
            }
            // tải lại form
            dgv.RefreshDataSource();
        }

        private void btnLuuPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
