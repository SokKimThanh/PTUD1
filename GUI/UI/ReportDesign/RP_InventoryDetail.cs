﻿using System;

namespace GUI.UI.ReportDesign
{
    public partial class RP_InventoryDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_InventoryDetail()
        {
            InitializeComponent();
        }
        public void Add(int _stockStatus, int _salesPerformance, DateTime _startDate, DateTime _endDate)
        {
            // Truyền tham số vào báo cáo
            this.Parameters["RP_SalesPerformance"].Value = _salesPerformance;
            this.Parameters["RP_StockStatus"].Value = _stockStatus;
            this.Parameters["RP_StartDate"].Value = _startDate;
            this.Parameters["RP_EndDate"].Value = _endDate;

            // Tắt field nhập parameter khi preview
            this.Parameters["RP_SalesPerformance"].Visible = false;
            this.Parameters["RP_StockStatus"].Visible = false;
            this.Parameters["RP_StartDate"].Visible = false;
            this.Parameters["RP_EndDate"].Visible = false;
        }
    }
}
