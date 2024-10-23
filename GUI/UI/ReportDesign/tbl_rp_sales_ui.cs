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
        private DateTime ngayBatDau, ngayKetThuc;



        public tbl_rp_sales_ui()
        {
            InitializeComponent();
        }

        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }

        public void Add()
        {
            // Thiết lập giá trị cho tham số StartDate và EndDate
            Parameters["StartDate"].Value = NgayBatDau;
            Parameters["EndDate"].Value = NgayKetThuc;

            // Ẩn tham số nếu không muốn hiển thị cho người dùng
            Parameters["StartDate"].Visible = false;
            Parameters["EndDate"].Visible = false;
        }
    }
}
