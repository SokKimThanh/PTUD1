using BUS.Bao_Cao;
using DevExpress.XtraReports.UI;
using GUI.UI.ReportDesign;
using System.Windows.Forms;
using System;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoTonKho : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        private DateTime startDate;
        private DateTime endDate;

        public ucBaoCaoTonKho()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
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
            executeReport();
        }
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (rptViewReport.SelectedIndex == 0) // Tổng quan
            {
                dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
                var report = new RP_Sales();
                report.Add(startDate, endDate);

                // Hiển thị báo cáo
                var printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            else // Chi tiết
            {
                dgv.DataSource = data.GetDetailSaleReport(startDate, endDate);
                // Bỏ chọn bên dưới để triển khai xem trước báo cáo chi tiết
                var detailedReport = new RP_SalesDetails();

                detailedReport.Add(startDate, endDate);

                var printTool2 = new ReportPrintTool(detailedReport);
                detailedReport.ShowPreview();  // Hiển thị báo cáo trong cửa sổ xem trước
            }
        }
        public void executeReport()
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
        public void executeReportDefault()
        {
            // Mặc định hiển thị báo cáo tổng quan
            rptViewReport.SelectedIndex = 0; 

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

