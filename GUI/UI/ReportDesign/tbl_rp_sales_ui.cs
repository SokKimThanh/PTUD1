using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace GUI.UI.ReportDesign
{
    public partial class tbl_rp_sales_ui : DevExpress.XtraReports.UI.XtraReport
    {
        public tbl_rp_sales_ui(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            // Thiết lập giá trị cho tham số StartDate và EndDate
            Parameters["StartDate"].Value = startDate;
            Parameters["EndDate"].Value = endDate;

            // Ẩn tham số nếu không muốn hiển thị cho người dùng
            Parameters["StartDate"].Visible = false;
            Parameters["EndDate"].Visible = false;
        }

    }
}
