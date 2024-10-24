using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors.Controls;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;

namespace GUI.UI.Modules
{
    public partial class ucPhanCa : ucBase
    {
        private tbl_DM_StaffSchedule_DTO objEdit = null;
        public ucPhanCa()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            grdData.OptionsBehavior.Editable = false;

        }
        protected override void Load_FirstBase()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
        }
    }
}
