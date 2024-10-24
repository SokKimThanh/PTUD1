using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using DTO.Custom;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_Sales : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly string _connectionString;

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
