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
            gridView1.OptionsBehavior.Editable = false;
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            tbl_DM_Bill_BUS v_objBillBus = new tbl_DM_Bill_BUS();
            tbl_DM_Staff_BUS v_objStaffBus = new tbl_DM_Staff_BUS();
            tbl_DM_Product_BUS v_objProductBus = new tbl_DM_Product_BUS();

            List<tbl_DM_Bill_DTO> v_arrBill = v_objBillBus.List_Data();
            foreach (tbl_DM_Bill_DTO v_objBill in v_arrBill)
            {
                v_objBill.BL_PRODUCT_NAME = v_objProductBus.Find(v_objBill.BL_PRODUCT_AutoID).PD_NAME;
                v_objBill.BL_NAME = v_objStaffBus.GetStaff_ByID((int)v_objBill.BL_STAFF_AutoID).ST_NAME;
            }

            dgv.DataSource = v_arrBill;

            gridView1.Columns["BL_AutoID"].Visible = false;
            gridView1.Columns["BL_PRODUCT_AutoID"].Visible = false;
            gridView1.Columns["BL_STAFF_AutoID"].Visible = false;

            gridView1.Columns["BL_PRODUCT_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên sản phẩm");
            gridView1.Columns["BL_NAME"].Caption = LanguageController.GetLanguageDataLabel("Người tạo hóa đơn");
            gridView1.Columns["BL_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            gridView1.Columns["BL_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");


            FormatGridView(gridView1);


        }
    }
}
