using BUS.Danh_Muc;
using DevExpress.XtraReports.UI;
using DTO.Common;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI.UI.ReportDesign
{
    public partial class RP_BaoCaoTonKho : DevExpress.XtraReports.UI.XtraReport
    {
        private tbl_DM_Staff_BUS tbl_DM_Staff_BUS = new tbl_DM_Staff_BUS();

        public RP_BaoCaoTonKho()
        {
            InitializeComponent();
        }
        public void Add(DateTime _startDate, DateTime _endDate)
        {
            // Truyền tham số vào báo cáo           
            this.Parameters["StartDate"].Value = _startDate;
            this.Parameters["EndDate"].Value = _endDate;
            this.Parameters["Performance"].Value = 50;
            this.Parameters["MinStock"].Value = 50;
            this.Parameters["Profit"].Value = 0.2;
            this.Parameters["NguoiLapBaoCao"].Value = tbl_DM_Staff_BUS.GetStaff_ByUserName(CCommon.MaDangNhap).ST_NAME;

            // Tắt field nhập parameter khi preview
            this.Parameters["StartDate"].Visible = false;
            this.Parameters["EndDate"].Visible = false;
            this.Parameters["NguoiLapBaoCao"].Visible = false;
            this.Parameters["Performance"].Visible = false;
            this.Parameters["MinStock"].Visible = false;
            this.Parameters["Profit"].Visible = false;
        }
    }
}
