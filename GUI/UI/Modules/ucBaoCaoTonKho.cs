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

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoTonKho : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        private int stock_status_selectedID;        // 1 = Cạn kiệt, 2 = Có sẵn, 3 = Quá tải
        private int sales_performance_selectedID;   // 1 = Bán chậm, 2 = Ổn định, 3 = Cháy hàng
        private DateTime startDate;
        private DateTime endDate;


        public ucBaoCaoTonKho()
        {
            InitializeComponent();
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;
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
            gridView1.Columns["ProductID"].Visible = false;
            gridView1.Columns["ProductName"].Caption = "Tên Sản phẩm";
            gridView1.Columns["CurrentStock"].Caption = "Tồn kho";
            gridView1.Columns["SoldQuantity"].Caption = "Đã bán";
            gridView1.Columns["UnitPrice"].Caption = "Đơn giá";
            gridView1.Columns["TotalInventoryValue"].Caption = "Tổng giá trị kho";
            gridView1.Columns["SalesPerformance"].Caption = "Hiệu suất bán hàng";
            gridView1.Columns["StockStatus"].Caption = "Tình trạng kho";
            gridView1.Columns["RecommendedAction"].Caption = "Gợi ý hành động";

            // Định dạng cột Tổng doanh thu
            gridView1.Columns["UnitPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["UnitPrice"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
            gridView1.Columns["TotalInventoryValue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalInventoryValue"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
        }

        private void txtStockStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (txtStockStatus.EditValue != null && txtStockStatus.SelectedItem is ComboBoxItem selectedItem)
            {
                stock_status_selectedID = selectedItem.Id;
            }
        }

        private void txtSalesPerformance_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSalesPerformance.EditValue != null && txtSalesPerformance.SelectedItem is ComboBoxItem selectedItem)
            {
                sales_performance_selectedID = selectedItem.Id;
            }
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
                txtSalesPerformance.Enabled = false;
                txtStockStatus.Enabled = false;
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
                dgv.DataSource = data.GetInventoryReport();
            }
            else
            {
                txtSalesPerformance.Enabled = true;
                txtStockStatus.Enabled = true;
                txtStartDate.Enabled = true;
                txtEndDate.Enabled = true;
                if (!DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                !DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv.DataSource = data.GetInventoryReportByStatusAndDate(stock_status_selectedID, sales_performance_selectedID, startDate, endDate);
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
                if (rptViewReport.SelectedIndex == 0) // Tổng quan
                {
                    dgv.DataSource = data.GetInventoryReport();
                }
                else // Chi tiết
                {
                    dgv.DataSource = data.GetInventoryReportByStatusAndDate(stock_status_selectedID, sales_performance_selectedID, startDate, endDate);
                    // Bỏ chọn bên dưới để triển khai xem trước báo cáo chi tiết
                    var detailedReport = new RP_InventoryDetail();

                    detailedReport.Add(stock_status_selectedID, sales_performance_selectedID, startDate, endDate);

                    var printTool2 = new ReportPrintTool(detailedReport);
                    detailedReport.ShowPreview();  // Hiển thị báo cáo trong cửa sổ xem trước
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void executeReport()
        {

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới 

            if (rptViewReport.SelectedIndex == 0)
            {
                dgv.DataSource = data.GetInventoryReport();
            }
            else
            {
                if (!DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                !DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgv.DataSource = data.GetInventoryReportByStatusAndDate(stock_status_selectedID, sales_performance_selectedID, startDate, endDate);
            }
            // Định dạng cột theo tổng quan hoặc chi tiết
            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }


        public void executeReportDefault()
        {
            // Tạo danh sách với ID và Name
            var SalesPerformanceListItem = new List<ComboBoxItem> {
                new ComboBoxItem { Id = 1, Name = "Bán chậm" },
                new ComboBoxItem { Id = 2, Name = "Ổn định" },
                new ComboBoxItem { Id = 3, Name = "Cháy hàng" }
            };
            var StockStatusListItem = new List<ComboBoxItem> {
                new ComboBoxItem { Id = 1, Name = "Cạn kiệt" },
                new ComboBoxItem { Id = 2, Name = "Có sẵn" },
                new ComboBoxItem { Id = 3, Name = "Quá tải" }
            };

            // Gán danh sách đối tượng vào ComboBoxEdit
            txtSalesPerformance.Properties.Items.AddRange(SalesPerformanceListItem);
            txtStockStatus.Properties.Items.AddRange(StockStatusListItem);

            // Mặc định hiển thị báo cáo tổng quan
            rptViewReport.SelectedIndex = 0;

            // Đặt khoảng thời gian cho năm hiện tại
            startDate = new DateTime(DateTime.Now.Year, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, 12, 31);

            // Hiển thị năm hiện tại lên các điều khiển
            txtStartDate.EditValue = startDate;
            txtEndDate.EditValue = endDate;

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

            // Mặc định trạng thái của kho va san pham
            txtSalesPerformance.SelectedIndex = 0;
            txtStockStatus.SelectedIndex = 0;

            sales_performance_selectedID = int.Parse(txtSalesPerformance.SelectedIndex.ToString());
            stock_status_selectedID = int.Parse(txtStockStatus.SelectedIndex.ToString());

            if (rptViewReport.SelectedIndex == 0)
            {
                dgv.DataSource = data.GetInventoryReport();
            }
            else
            {
                dgv.DataSource = data.GetInventoryReportByStatusAndDate(stock_status_selectedID, sales_performance_selectedID, startDate, endDate);
            }

            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }

        private void btnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReportDefault();
        }
    }
}

