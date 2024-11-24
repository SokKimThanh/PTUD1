using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DTO.tbl_DTO;
using System.Collections.Generic;
using System.Windows.Forms;

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
            grdData.OptionsBehavior.Editable = false;
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
            tbl_DM_Bill_BUS v_objBill_Bus = new tbl_DM_Bill_BUS();
            tbl_DM_Ticket_BUS v_objTiket = new tbl_DM_Ticket_BUS();
            tbl_DM_BillDetail_BUS v_objBillDetail = new tbl_DM_BillDetail_BUS();
            tbl_DM_Product_BUS v_objBus = new tbl_DM_Product_BUS();
            List<tbl_DM_Bill_DTO> v_arrData = v_objBill_Bus.List_Data();
            foreach (tbl_DM_Bill_DTO v_objItem in v_arrData)
            {
                v_objItem.Tiket = v_objTiket.List_Data_By_Bill_ID(v_objItem.BL_AutoID);
                v_objItem.Bill_Detail = v_objBillDetail.List_Data_By_Bill_ID(v_objItem.BL_AutoID);

                foreach (tbl_DM_BillDetail_DTO v_objDetail in v_objItem.Bill_Detail)
                {
                    v_objDetail.Product_Name = v_objBus.Find(v_objDetail.BD_PRODUCT_AutoID).PD_NAME;
                }
            }

            dgv.DataSource = v_arrData;
            grdData.Columns["BL_AutoID"].Visible = false;
            grdData.Columns["BL_STAFF_AutoID"].Visible = false;
            //grdData.Columns["Bill_Detail"].Visible = false;
            //grdData.Columns["Tiket"].Visible = false;

            grdData.Columns["BL_Bill_Code"].Caption = LanguageController.GetLanguageDataLabel("Mã hóa đơn");
            grdData.Columns["BL_Total_Price"].Caption = LanguageController.GetLanguageDataLabel("Tổng giá trị");
            FormatGridView(grdData);

            grdData.Columns["CREATED"].Visible = true;
            grdData.Columns["CREATED_BY"].Visible = true;

            grdData.Columns["CREATED"].Caption = LanguageController.GetLanguageDataLabel("Ngày giờ tạo");
            grdData.Columns["CREATED_BY"].Caption = LanguageController.GetLanguageDataLabel("Người tạo");

            GridLevelTree v_objTree = dgv.LevelTree;
        }

    }
}
