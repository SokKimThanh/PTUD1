using BUS.Danh_Muc;
using BUS.Sys;
using DTO.tbl_DTO;
using System.Collections.Generic;

namespace GUI.UI.Modules
{
    public partial class ucHoaDon : ucBase
    {
        public ucHoaDon()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gvHoaDonCT.OptionsBehavior.Editable = false;
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

           

            FormatGridView(gvHoaDonCT);
        }
    }
}
