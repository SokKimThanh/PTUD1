using BUS.Bao_Cao;
using DevExpress.XtraReports.UI;
using GUI.UI.ReportDesign;
using System.Windows.Forms;
using System;
using DevExpress.XtraRichEdit.Model;
using System.Runtime.InteropServices.ComTypes;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using GUI.UI.Component;
using DTO.Utility;
namespace GUI.UI.Modules
{
    public partial class ucBaoCaoTonKho : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        //private int stock_status_selectedID;        // 1 = Cạn kiệt, 2 = Có sẵn, 3 = Quá tải
        //private int sales_performance_selectedID;   // 1 = Bán chậm, 2 = Ổn định, 3 = Cháy hàng
        private DateTime startDate = new DateTime();
        private DateTime endDate = new DateTime();

        // Đặt khoảng thời gian cho năm hiện tại
        int year = DateTime.Now.Year;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();

        
        public ucBaoCaoTonKho()
        {
            InitializeComponent();
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;

            DateTime.TryParse($"{year}/01/01", out startDate);
            DateTime.TryParse($"{year}/12/31", out endDate);

            // Ngăn không cho phép chỉnh sửa trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(gridView1);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }

        protected override void Load_Data()
        {
            lblTitle.Text = !string.IsNullOrEmpty(strFunctionCode) ? strFunctionCode.ToUpper().Trim() : string.Empty;
            executeReportDefault();
        }

        /// <summary>
        /// Đặt tên tiếng việt cho các cột
        /// </summary>
        private void ConfigureGridColumns()
        {
            // Ghi tiếng việt cho các cột
            gridView1.Columns["ProductID"].Visible = false;
            gridView1.Columns["ProductName"].Caption = "Tên Sản phẩm";
            gridView1.Columns["ReceivedQuantity"].Caption = "SL Nhập";
            gridView1.Columns["RemainingStock"].Caption = "Số lượng còn tồn kho";
            gridView1.Columns["SoldQuantity"].Caption = "SL bán";
            gridView1.Columns["SalesPerformancePercentage"].Caption = "Tính hiệu suất bán hàng (%)";
            gridView1.Columns["SalesPerformanceCategory"].Caption = "Phân loại hiệu suất bán hàng";
            gridView1.Columns["StockStatus"].Caption = "Trạng thái tồn kho";
            gridView1.Columns["TotalImportCost"].Caption = "Tổng chi phí nhập hàng";
            gridView1.Columns["TotalRevenue"].Caption = "Tổng doanh thu từ sản phẩm";
            gridView1.Columns["TotalReceived"].Caption = "Tổng số lượng nhập";
            gridView1.Columns["TotalSold"].Caption = "Tổng số lượng bán";
            gridView1.Columns["Profit"].Caption = "Lợi nhuận từ sản phẩm";

            if (rptViewReport.SelectedIndex == 0)
            {
                gridView1.Columns["SalesPerformancePercentage"].Visible = false;
                gridView1.Columns["SalesPerformanceCategory"].Visible = false;
                gridView1.Columns["StockStatus"].Visible = false;
                gridView1.Columns["TotalImportCost"].Visible = false;
                gridView1.Columns["TotalRevenue"].Visible = false;
                gridView1.Columns["TotalReceived"].Visible = false;
                gridView1.Columns["TotalSold"].Visible = false;
                gridView1.Columns["Profit"].Visible = false;
            }
            else
            {
                gridView1.Columns["ReceivedQuantity"].Visible = false;
                gridView1.Columns["SoldQuantity"].Visible = false;
            }

            // Định dạng cột Tổng doanh thu
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["SalesPerformancePercentage"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["SalesPerformancePercentage"].DisplayFormat.FormatString = "n0"; // Định dạng tiền tệ

            gridView1.Columns["ReceivedQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["ReceivedQuantity"].DisplayFormat.FormatString = "N0"; // Định dạng tiền tệ

            gridView1.Columns["Profit"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Profit"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["TotalRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalRevenue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
        }
        private void txtStartDate_EditValueChanged(object sender, EventArgs e)
        {
            startDate = txtStartDate.DateTime;
        }

        private void txtEndDate_EditValueChanged(object sender, EventArgs e)
        {
            endDate = txtEndDate.DateTime;
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
            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới 

            if (rptViewReport.SelectedIndex == 0)
            {

                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
                dgv.DataSource = data.GetInventoryReport(startDate, endDate);
            }
            else
            {

                txtStartDate.Enabled = true;
                txtEndDate.Enabled = true;
                if (!DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                !DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate);
            }
            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chi tiết báo cáo tồn kho
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                var report = new RP_BaoCaoTonKho();
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
            if (!DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) && !DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime.TryParse(txtStartDate.Text.Trim(), out startDate);
            DateTime.TryParse(txtEndDate.Text.Trim(), out endDate);

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

            if (rptViewReport.SelectedIndex == 0)
            {

                dgv.DataSource = data.GetInventoryReport(startDate, endDate);
            }
            else
            {

                dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate);
            }
            // Định dạng cột theo tổng quan hoặc chi tiết
            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }


        public void executeReportDefault()
        {
            try
            {

                // Mặc định hiển thị báo cáo tổng quan
                rptViewReport.SelectedIndex = 0;





                if (startDate < new DateTime(1753, 1, 1) || endDate > new DateTime(9999, 12, 31))
                {
                    MessageBox.Show("Ngày tháng phải nằm trong khoảng từ 1/1/1753 đến 12/31/9999!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Hiển thị năm hiện tại lên các điều khiển
                txtStartDate.EditValue = startDate;
                txtEndDate.EditValue = endDate;

                gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới 

                if (rptViewReport.SelectedIndex == 0)
                {
                    dgv.DataSource = data.GetInventoryReport(startDate, endDate);
                }
                else
                {
                    dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate);
                }

                ConfigureGridColumns();

                // Refresh lại DataGridView để hiển thị dữ liệu mới
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReportDefault();
        }
    }
}

