using BUS.Bao_Cao;
using DevExpress.XtraReports.UI;
using GUI.UI.ReportDesign;
using System;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoThuChi : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        private DateTime startDate;
        private DateTime endDate;

        public ucBaoCaoThuChi()
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
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
            executeReportDefault();
        }
        private void ConfigureGridColumns()
        {
            gridView1.Columns["TotalExpenses"].Caption = "Tổng chi phí";
            gridView1.Columns["NumberOfExpenses"].Caption = "Số lượng các bản ghi chi phí";

            // Định dạng cột Tổng doanh thu
            gridView1.Columns["TotalExpenses"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["TotalExpenses"].DisplayFormat.FormatString = "c0"; // Định dạng tiền tệ
        }
        public void executeReport()
        {
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới

                dgv.DataSource = data.GetExpenseReport(startDate, endDate);

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
            // Đặt khoảng thời gian cho năm hiện tại
            startDate = new DateTime(DateTime.Now.Year, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, 12, 31);

            // Hiển thị năm hiện tại lên các điều khiển
            txtStartDate.EditValue = startDate;
            txtEndDate.EditValue = endDate;

            gridView1.Columns.Clear(); // Xóa cột cũ trước khi gán dữ liệu mới


            dgv.DataSource = data.GetExpenseReport(startDate, endDate);


            ConfigureGridColumns();

            // Refresh lại DataGridView để hiển thị dữ liệu mới
            dgv.Refresh();
        }


        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReport();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            executeReportDefault();
        }
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {

                dgv.DataSource = data.GetExpenseReport(startDate, endDate);

                var report = new RP_Expense();
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


    }
}
