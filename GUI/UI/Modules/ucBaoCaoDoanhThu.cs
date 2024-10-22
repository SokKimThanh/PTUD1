using BUS.Bao_Cao;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UI.ReportDesign;
using DevExpress.XtraRichEdit.Model;
using System.Runtime.InteropServices.ComTypes;

namespace GUI.UI.Modules
{
    public partial class ucBaoCaoDoanhThu : ucBase
    {
        private tbl_Report_BUS data = new tbl_Report_BUS();
        DateTime startDate;
        DateTime endDate;

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

            // Mặc định hiển thị báo cáo tổng quan
            rptViewReport.SelectedIndex = 0;

            // tổng quan năm hiện tại
            startDate = new DateTime(DateTime.Now.Year, 1, 1);
            endDate = new DateTime(DateTime.Now.Year, 12, 31);
            dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
            if (rptViewReport.SelectedIndex == 0)
            {
                // tổng quan
                gridView1.Columns["MovieName"].Caption = "Tên phim";
                gridView1.Columns["TotalRevenue"].Caption = "Tổng doanh thu";
                gridView1.Columns["TotalTicketsSold"].Caption = "Tổng vé bán";

                // Định dạng cột Tổng doanh thu
                gridView1.Columns["TotalRevenue"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TotalRevenue"].DisplayFormat.FormatString = "c0"; // Hiển thị tiền tệ
            }
            else
            {
                // chi tiết 
                gridView1.Columns["MovieName"].Caption = "Tên phim";
                gridView1.Columns["ShowTime"].Caption = "Thời gian chiếu";
                gridView1.Columns["TicketPrice"].Caption = "Giá vé";
                gridView1.Columns["SaleTime"].Caption = "Thời gian bán";
                gridView1.Columns["TheaterName"].Caption = "Phòng chiếu";

                // Định dạng cột Giá vé
                gridView1.Columns["TicketPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["TicketPrice"].DisplayFormat.FormatString = "c0"; // Hiển thị tiền tệ
            }
            // hiển thị năm hiện tại lên control
            txtStartDate.EditValue = startDate;
            txtEndDate.EditValue = endDate;

            // tải lại form
            dgv.RefreshDataSource();
        }

        private void btnThucThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) && DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                // hiển thị danh sách báo cáo
                if (rptViewReport.SelectedIndex == 0)
                {
                    // tổng quan
                    dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
                }
                else
                {
                    // chi tiết 
                    dgv.DataSource = data.GetDetailSaleReport(startDate, endDate);
                }
                // tải lại form
                dgv.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        /// <summary>
        /// Hàm tạo report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaoBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.TryParse(txtStartDate.Text.Trim(), out startDate) &&
                DateTime.TryParse(txtEndDate.Text.Trim(), out endDate))
            {
                // hiển thị danh sách báo cáo
                if (rptViewReport.SelectedIndex == 0)
                {
                    // tổng quan
                    dgv.DataSource = data.GetAllSalesReport(startDate, endDate);
                    tbl_rp_sales_ui report = new tbl_rp_sales_ui(startDate, endDate);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();  // Hiển thị báo cáo trong cửa sổ Preview
                }
                else
                {
                    // chi tiết 
                    dgv.DataSource = data.GetDetailSaleReport(startDate, endDate);
                    //tbl_rp_sales_details_ui report = new tbl_rp_sales_details_ui(startDate, endDate);
                    //ReportPrintTool printTool = new ReportPrintTool(report);
                    //printTool.ShowPreview();  // Hiển thị báo cáo trong cửa sổ Preview
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // tải lại form
            dgv.RefreshDataSource();
        }
    }
}
