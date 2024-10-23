using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_SalesDetails : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_SalesDetails()
        {
            InitializeComponent();
        }
        public void Add(DateTime _ngayBatDau, DateTime _ngayKetThuc)
        {
            // Thiết lập giá trị cho tham số StartDate và EndDate
            this.Parameters["RP_StartDate"].Value = _ngayBatDau;
            this.Parameters["RP_EndDate"].Value = _ngayKetThuc;

            // Ẩn tham số nếu không muốn hiển thị cho người dùng
            this.Parameters["RP_StartDate"].Visible = false;
            this.Parameters["RP_EndDate"].Visible = false;
        }
    }
}
