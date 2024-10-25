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
            tbl_DM_StaffSchedule_BUS objBUS = new tbl_DM_StaffSchedule_BUS();
            //Load 2 cbb lên
            tbl_DM_Shift_BUS objShiftBUS = new tbl_DM_Shift_BUS();

            // Lấy danh sách ca làm
            cbbCaLamViec.Properties.DataSource = objShiftBUS.ListData();
            cbbCaLamViec.Properties.DisplayMember = "SF_NAME";
            cbbCaLamViec.Properties.ValueMember = "SF_AutoID";
            cbbCaLamViec.Properties.Columns.Clear();
            cbbCaLamViec.Properties.Columns.Add(new LookUpColumnInfo("SF_NAME", "Tên ca"));
            cbbCaLamViec.Properties.Columns.Add(new LookUpColumnInfo("ST_NAME", "Nhân viên"));
                
            cbbCaLamViec.Properties.Columns.Add(new LookUpColumnInfo("SF_START", "Bắt đầu"));
            cbbCaLamViec.Properties.Columns.Add(new LookUpColumnInfo("SF_END", "Kết thúc"));
            cbbCaLamViec.SelectionStart = 0;

            tbl_DM_Staff_BUS objStaffBUS = new tbl_DM_Staff_BUS();
            List<tbl_DM_Staff_DTO> arrStaffs = objStaffBUS.ListData().Where(it => it.ST_LEVEL == (int)ELevel.Staff).ToList();
            cbbNhanVien.Properties.DataSource = arrStaffs;
            cbbNhanVien.Properties.DisplayMember = "ST_NAME";
            cbbNhanVien.Properties.ValueMember = "ST_AutoID";
            cbbNhanVien.Properties.Columns.Clear();
            cbbNhanVien.Properties.Columns.Add(new LookUpColumnInfo("ST_NAME", "Tên nhân viên"));

            cbbCaLamViec.EditValue = null;
            cbbNhanVien.EditValue = null;


            // Focus vào ComboBoxEdit
            cbbCaLamViec.Focus();
            cbbNhanVien.Focus();
            dgv.DataSource = objBUS.ListData();

            grdData.Columns["SS_AutoID"].Visible = false;
            grdData.Columns["SS_STAFF_AutoID"].Visible = false;
            grdData.Columns["SS_SHIFT_AutoID"].Visible = false;

            grdData.Columns["ST_USERNAME"].Caption = LanguageController.GetLanguageDataLabel("Mã đăng nhập");
            grdData.Columns["ST_NAME"].Caption = LanguageController.GetLanguageDataLabel("Nhân viên");
            grdData.Columns["SF_NAME"].Caption = LanguageController.GetLanguageDataLabel("Ca làm");

            grdData.Columns["SF_START"].Caption = LanguageController.GetLanguageDataLabel("Bắt đầu");
            grdData.Columns["SF_END"].Caption = LanguageController.GetLanguageDataLabel("Kết thúc");

            FormatGridView(grdData);
        }

        protected override void Add_Data()
        {
            tbl_DM_StaffSchedule_BUS objBUS = new tbl_DM_StaffSchedule_BUS();
            tbl_DM_StaffSchedule_DTO objNew = new tbl_DM_StaffSchedule_DTO();

            if (cbbNhanVien.EditValue != null && cbbNhanVien.EditValue.ToString() != "")
                objNew.SS_STAFF_AutoID = Convert.ToInt64(cbbNhanVien.EditValue.ToString());

            if (cbbCaLamViec.EditValue != null && cbbCaLamViec.EditValue.ToString() != "")
                objNew.SS_SHIFT_AutoID = Convert.ToInt64(cbbCaLamViec.EditValue.ToString());

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
            tbl_DM_StaffSchedule_BUS objBUS = new tbl_DM_StaffSchedule_BUS();

            if (objEdit != null)
            {
                if (cbbNhanVien.EditValue != null && cbbNhanVien.EditValue.ToString() != "")
                    objEdit.SS_STAFF_AutoID = Convert.ToInt64(cbbNhanVien.EditValue.ToString());

                if (cbbCaLamViec.EditValue != null && cbbCaLamViec.EditValue.ToString() != "")
                    objEdit.SS_SHIFT_AutoID = Convert.ToInt64(cbbCaLamViec.EditValue.ToString());

                objEdit.UPDATED = DateTime.Now;
                objEdit.UPDATED_BY = strActive_User_Name;
                objEdit.UPDATED_BY_FUNCTION = strFunctionCode;

                objBUS.UpdateData(objEdit);
            }

        }

        protected override void RemoveData(long iAuto_ID)
        {

            tbl_DM_StaffSchedule_BUS objBUS = new tbl_DM_StaffSchedule_BUS();
            objBUS.RemoveData(iAuto_ID, strActive_User_Name, strFunctionCode);
        }

        protected override void ObjectProcessing(object obj)
        {
            objEdit = obj as tbl_DM_StaffSchedule_DTO;

            iAuto_ID = objEdit.SS_AutoID;

            List<tbl_DM_Shift_DTO> arrShifts = cbbCaLamViec.Properties.DataSource as List<tbl_DM_Shift_DTO>;
            cbbCaLamViec.EditValue = objEdit.SS_SHIFT_AutoID;


            List<tbl_DM_Staff_DTO> arrStaft = cbbNhanVien.Properties.DataSource as List<tbl_DM_Staff_DTO>;
            cbbNhanVien.EditValue = objEdit.SS_STAFF_AutoID;

        }
    }
}
