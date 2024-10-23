using BUS.Danh_Muc;
using BUS.Sys;
using DTO.Custom;
using DTO.tbl_DTO;
using DTO.Utility;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace GUI.UI.Modules
{
    public partial class ucCaLamViec : ucBase
    {
        private List<tbl_DM_Shift_DTO> arrData = new List<tbl_DM_Shift_DTO>();
        private tbl_DM_Shift_DTO objEdit = null;

        public ucCaLamViec()
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

            btnThem.ItemClick += Add_DataBase;
            btnXoa.ItemClick += Remove_DataBase;
            btnCapNhat.ItemClick += Update_DataBase;
            btnLamMoi.ItemClick += Refresh_Load_DataBase;

            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            grdData.OptionsBehavior.Editable = false;

            grdData.RowClick += RowClick_Grid;

        }

        protected override void Load_Data()
        {
            tbl_DM_Shift_BUS objBUS = new tbl_DM_Shift_BUS();

            arrData = objBUS.ListData();
            dgv.DataSource = arrData;

            objEdit = null;

            txtTCLV.Text = "";
            dtmFrom.Time = DateTime.Now;
            dtmTo.Time = DateTime.Now;

            grdData.Columns["SF_AutoID"].Visible = false;
            grdData.Columns["SF_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên ca");
            grdData.Columns["SF_START"].Caption = LanguageController.GetLanguageDataLabel("Bắt đầu");
            grdData.Columns["SF_END"].Caption = LanguageController.GetLanguageDataLabel("Kết thúc");

            FormatGridView(grdData);

            grdData.Columns["SF_START"].DisplayFormat.FormatString = CConfig.Time_Format_String;
            grdData.Columns["SF_END"].DisplayFormat.FormatString = CConfig.Time_Format_String;
        }

        protected override void Add_Data()
        {
            tbl_DM_Shift_BUS objBUS = new tbl_DM_Shift_BUS();
            tbl_DM_Shift_DTO objNew = new tbl_DM_Shift_DTO();

            objNew.SF_NAME = txtTCLV.Text.Trim();
            objNew.SF_START = dtmFrom.Time;
            objNew.SF_END = dtmTo.Time;

            objNew.DELETED = 0;
            objNew.CREATED = DateTime.Now;
            objNew.CREATED_BY = strActive_User_Name;
            objNew.CREATED_BY_FUNCTION = strFunctionCode;
            objNew.UPDATED = DateTime.Now;
            objNew.UPDATED_BY = strActive_User_Name;
            objNew.UPDATED_BY_FUNCTION = strFunctionCode;

            objBUS.AddData(objNew);
        }

        protected override void Update_Data()
        {
            tbl_DM_Shift_BUS objBUS = new tbl_DM_Shift_BUS();
            tbl_DM_Shift_DTO obj = new tbl_DM_Shift_DTO();
            obj.SF_AutoID = iAuto_ID;
            obj.SF_NAME = txtTCLV.Text.Trim();
            obj.SF_START = dtmFrom.Time;
            obj.SF_END = dtmTo.Time;

            obj.DELETED = 0;
            obj.CREATED = DateTime.Now;
            obj.CREATED_BY = strActive_User_Name;
            obj.CREATED_BY_FUNCTION = strFunctionCode;
            obj.UPDATED = DateTime.Now;
            obj.UPDATED_BY = strActive_User_Name;
            obj.UPDATED_BY_FUNCTION = strFunctionCode;


            obj.UPDATED = DateTime.Now;
            obj.UPDATED_BY = strActive_User_Name;
            obj.UPDATED_BY_FUNCTION = strFunctionCode;

            objBUS.UpdateData(obj);
        }

        protected override void RemoveData(long iAuto_ID)
        {
            tbl_DM_Shift_BUS objBUS = new tbl_DM_Shift_BUS();
            objBUS.RemoveData(iAuto_ID, strActive_User_Name, strFunctionCode);
        }

        protected override void ObjectProcessing(object obj)
        {
            objEdit = obj as tbl_DM_Shift_DTO;
            iAuto_ID = objEdit.SF_AutoID;
            txtTCLV.Text = objEdit.SF_NAME.Trim();
            dtmFrom.Time = objEdit.SF_START;
            dtmTo.Time = objEdit.SF_END;
        }
    }
}
