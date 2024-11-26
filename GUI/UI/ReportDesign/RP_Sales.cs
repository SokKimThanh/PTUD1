using System;

namespace GUI.UI.ReportDesign
{
    public partial class RP_Sales : DevExpress.XtraReports.UI.XtraReport
    {


        public RP_Sales()
        {
            InitializeComponent();

        }

        public void Add(DateTime _startDate, DateTime _endDate)
        {
            // Truyền tham số vào báo cáo
            this.Parameters["RP_StartDate"].Value = _startDate;
            this.Parameters["RP_EndDate"].Value = _endDate;

            // Tắt field nhập parameter khi preview
            this.Parameters["RP_StartDate"].Visible = false;
            this.Parameters["RP_EndDate"].Visible = false;
        }
    }
}
