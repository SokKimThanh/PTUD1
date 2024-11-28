using BUS.Bao_Cao;
using DevExpress.XtraReports.UI;
using GUI.UI.Component;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoDoanhThu : ucBase
    {
        // Danh sách trạng thái
        Dictionary<int, string> dsLoaiDoanhThu = new Dictionary<int, string>()
        {
            {0, "Doanh thu sản phẩm" },
            {1, "Doanh thu suất chiếu" }
        };


        private tbl_Report_BUS data = new tbl_Report_BUS();
        private DateTime startDate;
        private DateTime endDate;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();

        public ucBaoCaoDoanhThu()
        {
            InitializeComponent();

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
                btnTaoBaoCao.Enabled = true;
                if ((int)cboLoaiDoanhThu.EditValue == 0)
                {

                    gridView1.Columns["ProductName"].Caption = "Tên sản phẩm";
                    gridView1.Columns["UnitPrice"].Caption = "Đơn giá";
                    gridView1.Columns["TotalQuantitySold"].Caption = "Tổng số lượng bán sản phẩm";
                    gridView1.Columns["TotalProductRevenue"].Caption = "Tổng doanh thu sản phẩm";

                    // Định dạng cột tổng tiền
                    gridView1.Columns["TotalProductRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridView1.Columns["TotalProductRevenue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
                }
                else
                {
                    gridView1.Columns["MovieName"].Caption = "Tên phim";
                    gridView1.Columns["TicketPrice"].Caption = "Giá vé";
                    gridView1.Columns["TotalTickets"].Caption = "Tổng số lượng vé";
                    gridView1.Columns["TotalTicketRevenue"].Caption = "Tổng doanh thu vé";

                    // Định dạng cột tổng tiền
                    gridView1.Columns["TotalTicketRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    gridView1.Columns["TotalTicketRevenue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
                }
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

            try
            {
                DateTime.TryParse(txtStartDate.Text.Trim(), out startDate);
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate);

                var report = new RP_BaoCaoDoanhThu();
                report.Add(startDate, endDate);

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
                    dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
                    cboLoaiDoanhThu.Enabled = false;// Ẩn cbo loại doanh thu
                    btnTaoBaoCao.Enabled = false;
                }
                else
                {
                    cboLoaiDoanhThu.Enabled = true;// Hiện cbo loại doanh thu
                    btnTaoBaoCao.Enabled = true;
                    if ((int)cboLoaiDoanhThu.EditValue == 0)
                    {
                        dgv.DataSource = data.GetProductRevenue(startDate, endDate);
                    }
                    else
                    {
                        dgv.DataSource = data.GetTicketRevenue(startDate, endDate);
                    }
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
            btnTaoBaoCao.Enabled = false;
            cboLoaiDoanhThu.Enabled = false;
            cboLoaiDoanhThu.Properties.DataSource = dsLoaiDoanhThu;
            cboLoaiDoanhThu.EditValue = 0;    // Mặc định chọn "Doanh thu vé" 

            // Mặc định hiển thị báo cáo tổng quan
            rptViewReport.SelectedIndex = 0;

            // Đặt khoảng thời gian cho năm hiện tại
            startDate = new DateTime(DateTime.Now.Year, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, 12, 31);

            // Hiển thị năm hiện tại lên các điều khiển
            txtStartDate.EditValue = startDate;
            txtEndDate.EditValue = endDate;

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

            // Đặt ngày chọn ban đầu
            txtEndDate.Properties.MinValue = startDate;// ngày nhỏ nhất của end date là start date


            if (rptViewReport.SelectedIndex == 0)
            {
                dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
            }
            else
            {
                // doanh thu sản phẩm
                if ((int)cboLoaiDoanhThu.EditValue == 0)
                {
                    dgv.DataSource = data.GetProductRevenue(startDate, endDate);
                }
                // doanh thu suất chiếu
                else
                {
                    dgv.DataSource = data.GetTicketRevenue(startDate, endDate);
                }
            }

            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
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
    }
}
