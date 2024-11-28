using BUS.Bao_Cao;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using GUI.UI.Component;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI.UI.Modules
{
    public partial class ucBaoCaoTonKho : ucBase
    {
        // Danh sách trạng thái
        Dictionary<int, string> dsTrangThaiTonKho = new Dictionary<int, string>()
        {
            {0, "Thiếu hàng" },
            {1, "Đủ hàng" }
        };


        private tbl_Report_BUS data = new tbl_Report_BUS();

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
            gridView1.Columns["ProductID"].Caption = "Mã sản phẩm";
            gridView1.Columns["ProductName"].Caption = "Tên Sản phẩm";
            gridView1.Columns["ReceivedQuantity"].Caption = "Số lượng nhập";
            gridView1.Columns["TotalImportCost"].Caption = "Tổng chi phí nhập hàng";
            gridView1.Columns["UnitCost"].Caption = "Giá nhập";
            gridView1.Columns["SoldQuantity"].Caption = "Số lượng bán";
            gridView1.Columns["UnitPrice"].Caption = "Giá bán";
            gridView1.Columns["TotalRevenue"].Caption = "Tổng doanh thu từ sản phẩm";
            gridView1.Columns["RestockStatus"].Caption = "Trạng thái kho";
            gridView1.Columns["RemainingStock"].Caption = "Tồn kho";


            if (rptViewReport.SelectedIndex == 0)
            {

                gridView1.Columns["ProductID"].Visible = false;
                gridView1.Columns["SoldQuantity"].Visible = false;
                gridView1.Columns["UnitPrice"].Visible = false;
                gridView1.Columns["TotalRevenue"].Visible = false;
                gridView1.Columns["RestockStatus"].Visible = false;
                gridView1.Columns["RemainingStock"].Visible = false;
                gridView1.Columns["UnitCost"].Visible = false;
            }
            else
            {
                gridView1.Columns["ProductID"].Visible = false;
                gridView1.Columns["TotalImportCost"].Visible = false;
                gridView1.Columns["UnitCost"].Visible = false;
                gridView1.Columns["UnitPrice"].Visible = false;
                gridView1.Columns["TotalRevenue"].Visible = false;
                gridView1.Columns["RemainingStock"].Visible = false;

            }

            // Định dạng cột Tổng doanh thu
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["ReceivedQuantity"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["ReceivedQuantity"].DisplayFormat.FormatString = "N0"; // Định dạng tiền tệ

            gridView1.Columns["UnitPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["UnitPrice"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalImportCost"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ

            gridView1.Columns["TotalRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalRevenue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
        }
        private void txtStartDate_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStartDate.EditValue != null && txtEndDate.EditValue != null)
            {
                startDate = (DateTime)txtStartDate.EditValue;
                endDate = (DateTime)txtEndDate.EditValue;
                txtEndDate.Properties.MinValue = (DateTime)txtStartDate.EditValue;
            }
        }

        private void txtEndDate_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStartDate.EditValue != null && txtEndDate.EditValue != null)
            {
                startDate = (DateTime)txtStartDate.EditValue;
                endDate = (DateTime)txtEndDate.EditValue;
                txtEndDate.Properties.MinValue = (DateTime)txtStartDate.EditValue;
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
            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới 

            // bao cao tong hop
            if (rptViewReport.SelectedIndex == 0)
            {

                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
                btnTaoBaoCao.Enabled = false; // khong cho tao bao cao tong hop
                cboInventoryStatus.Enabled = false;
                dgv.DataSource = data.GetInventoryReport(startDate, endDate);
            }
            // bao cao chi tiet
            else
            {
                txtStartDate.Enabled = true;
                txtEndDate.Enabled = true;
                btnTaoBaoCao.Enabled = true;
                cboInventoryStatus.Enabled = true;


                DateTime.TryParse(txtStartDate.Text.Trim(), out startDate);
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate);

                dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate, 50, 50, 0.2, (int)cboInventoryStatus.EditValue);
            }
            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                DateTime.TryParse(txtStartDate.Text.Trim(), out startDate);
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate);

                var report = new RP_BaoCaoTonKho();

                report.Add(startDate, endDate, (int)cboInventoryStatus.EditValue);

                // Hiển thị báo cáo
                var printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void executeReport()
        {
            try
            {

                DateTime.TryParse(txtStartDate.Text.Trim(), out startDate);
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate);

                gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

                if (rptViewReport.SelectedIndex == 0)
                {

                    dgv.DataSource = data.GetInventoryReport(startDate, endDate);
                }
                else
                {
                    dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate, 50, 50, 0.2, (int)cboInventoryStatus.EditValue);
                }
                // Định dạng cột theo tổng quan hoặc chi tiết
                ConfigureGridColumns();

                // Refresh lại DataGridView để hiển thị dữ liệu mới
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void executeReportDefault()
        {
            try
            {
                btnTaoBaoCao.Enabled = false;

                // cbo trang thai
                cboInventoryStatus.Enabled = false;
                cboInventoryStatus.Properties.DataSource = dsTrangThaiTonKho;
                cboInventoryStatus.EditValue = 0;    // Mặc định chọn "Thiếu hàng" 

                // Mặc định hiển thị báo cáo tổng quan
                rptViewReport.SelectedIndex = 0;

                // Hiển thị năm hiện tại lên các điều khiển
                txtStartDate.EditValue = startDate;
                txtEndDate.EditValue = endDate;

                // Đặt ngày chọn ban đầu
                txtEndDate.Properties.MinValue = startDate;// ngày nhỏ nhất của end date là start date

                gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới 

                if (rptViewReport.SelectedIndex == 0)
                {
                    dgv.DataSource = data.GetInventoryReport(startDate, endDate);
                }
                else
                {
                    dgv.DataSource = data.GetInventoryReportByStatusAndDate(startDate, endDate, 50, 50, 0.2, (int)cboInventoryStatus.EditValue);
                }

                ConfigureGridColumns();

                // Refresh lại DataGridView để hiển thị dữ liệu mới
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReportDefault();
        }
    }
}

