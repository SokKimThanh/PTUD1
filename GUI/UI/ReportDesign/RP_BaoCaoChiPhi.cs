using BUS.Danh_Muc;
using DTO.Common;
using System;

namespace GUI.UI.ReportDesign
{
    public partial class RP_BaoCaoChiPhi : DevExpress.XtraReports.UI.XtraReport
    {
        private tbl_DM_Staff_BUS tbl_DM_Staff_BUS = new tbl_DM_Staff_BUS();

        public RP_BaoCaoChiPhi()
        {
            InitializeComponent();
        }

        public void Add(DateTime _startDate, DateTime _endDate)
        {
            // Truyền tham số vào báo cáo           
            this.Parameters["StartDate"].Value = _startDate;
            this.Parameters["EndDate"].Value = _endDate;
            this.Parameters["NguoiLapBaoCao"].Value = tbl_DM_Staff_BUS.GetStaff_ByUserName(CCommon.MaDangNhap).ST_NAME;

            // Tắt field nhập parameter khi preview
            this.Parameters["StartDate"].Visible = false;
            this.Parameters["EndDate"].Visible = false;
            this.Parameters["NguoiLapBaoCao"].Visible = false;
        }
    }
}
