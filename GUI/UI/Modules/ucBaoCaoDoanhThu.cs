using BUS.Bao_Cao;
using DevExpress.DataAccess.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using GUI.UI.ReportDesign;
using System;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoDoanhThu : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        private DateTime startDate;
        private DateTime endDate;

        public ucBaoCaoDoanhThu()
        {
            InitializeComponent();
            // Ngăn không cho phép chỉnh sửa trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;
        }

        protected override void Load_Data()
        {
            lblTitle.Text = !string.IsNullOrEmpty(strFunctionCode) ? strFunctionCode.ToUpper().Trim() : string.Empty;
            executeReportDefault();
        }

        private void ConfigureGridColumns()
        {
            if (rptViewReport.SelectedIndex == 0) // Tổng quan
            {
                gridView1.Columns["MovieName"].Caption = "Tên phim";
                gridView1.Columns["TotalRevenue"].Caption = "Tổng doanh thu";
                gridView1.Columns["TotalTicketsSold"].Caption = "Tổng vé bán";

                // Định dạng cột Tổng doanh thu
                gridView1.Columns["TotalRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalRevenue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
            }
            else // Chi tiết
            {
                gridView1.Columns["MovieName"].Caption = "Tên phim";
                gridView1.Columns["ShowTime"].Caption = "Thời gian chiếu";
                gridView1.Columns["TicketPrice"].Caption = "Giá vé";
                gridView1.Columns["SaleTime"].Caption = "Thời gian bán";
                gridView1.Columns["TheaterName"].Caption = "Phòng chiếu";

                // Định dạng cột Giá vé
                gridView1.Columns["TicketPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TicketPrice"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
            }
        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReport();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReportDefault();
        }

        private void rptViewReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtStartDate.Text != "" && txtEndDate.Text != "")
            {
                executeReport();
            }
        } 
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                var report = new RP_BaoCaoDoanhThu();
                report.Add(startDate, endDate);

                // Hiển thị báo cáo
                var printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void executeReport()
        {

            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

                if (rptViewReport.SelectedIndex == 0)
                {
                    dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
                }
                else
                {
                    dgv.DataSource = data.GetDetailSaleReport(startDate, endDate);
                }

                // Định dạng cột theo tổng quan hoặc chi tiết
                ConfigureGridColumns();

                // Refresh lại DataGridView để hiển thị dữ liệu mới
                dgv.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void executeReportDefault()
        {
            // Mặc định hiển thị báo cáo tổng quan
            rptViewReport.SelectedIndex = 0;

            // Đặt khoảng thời gian cho năm hiện tại
            startDate = new DateTime(DateTime.Now.Year, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, 12, 31);

            // Hiển thị năm hiện tại lên các điều khiển
            txtStartDate.EditValue = startDate;
            txtEndDate.EditValue = endDate;

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới


            if (rptViewReport.SelectedIndex == 0)
            {
                dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
            }
            else
            {
                dgv.DataSource = data.GetDetailSaleReport(startDate, endDate);
            }

            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }
    }
}
