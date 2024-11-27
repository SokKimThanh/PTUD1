using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using GUI.UI.Component;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucHoaDon : ucBase
    {
        // Selected bill's id
        private long selectedBill_AutoID = -1;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
        private void IsUsing(bool isUsing)
        {
            btnIn.Enabled = isUsing;
        }
        public ucHoaDon()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            grdData.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(grdData);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
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
            grdData.Columns["BL_Trang_Thai_ID"].Visible = false;
            //grdData.Columns["Bill_Detail"].Visible = false;
            //grdData.Columns["Tiket"].Visible = false;

            grdData.Columns["BL_Bill_Code"].Caption = LanguageController.GetLanguageDataLabel("Mã hóa đơn");
            grdData.Columns["BL_Total_Price"].Caption = LanguageController.GetLanguageDataLabel("Tổng giá trị");
            grdData.Columns["BL_Trang_Thai_Text"].Caption = LanguageController.GetLanguageDataLabel("Trạng thái");

            FormatGridView(grdData);

            grdData.Columns["CREATED"].Visible = true;
            grdData.Columns["CREATED_BY"].Visible = true;

            grdData.Columns["CREATED"].Caption = LanguageController.GetLanguageDataLabel("Ngày giờ tạo");
            grdData.Columns["CREATED_BY"].Caption = LanguageController.GetLanguageDataLabel("Người tạo");

            GridLevelTree v_objTree = dgv.LevelTree;
            selectedBill_AutoID = -1;
            IsUsing(false);
        }

        protected override void Update_Data()
        {

        }

        private void grdData_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                // Cast sender về GridView
                GridView objGridView = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                if (objGridView != null)
                {
                    // Lấy dữ liệu của hàng hiện tại (hàng được chọn)
                    object objSelectRow = objGridView.GetRow(objGridView.FocusedRowHandle);

                    tbl_DM_Bill_DTO v_objRes = objSelectRow as tbl_DM_Bill_DTO;

                    tbl_DM_Bill_BUS v_objBill_Bus = new tbl_DM_Bill_BUS();
                    tbl_DM_BillDetail_BUS v_objBill_Detail_BUS = new tbl_DM_BillDetail_BUS();
                    tbl_DM_Ticket_BUS v_objTiket_BUS = new tbl_DM_Ticket_BUS();
                    tbl_DM_Product_BUS v_objProduct_BUS = new tbl_DM_Product_BUS();
                    tbl_DM_MovieSchedule_BUS v_objMovieSchedule_Bus = new tbl_DM_MovieSchedule_BUS();
                    tbl_DM_Movie_BUS v_objMovie_Bus = new tbl_DM_Movie_BUS();

                    //Tính tiền cần thanh toán dựa trên ghế và sản phẩm
                    v_objRes.Bill_Detail = v_objBill_Detail_BUS.List_Data_By_Bill_ID(v_objRes.BL_AutoID);
                    v_objRes.Tiket = v_objTiket_BUS.List_Data_By_Bill_ID(v_objRes.BL_AutoID);


                    double v_dblTong_Tien_SP = 0;
                    foreach (tbl_DM_BillDetail_DTO v_objBillDetail in v_objRes.Bill_Detail)
                    {
                        tbl_DM_Product_DTO v_objSP = v_objProduct_BUS.Find(v_objBillDetail.BD_PRODUCT_AutoID);
                        if (v_objSP != null)
                        {
                            v_dblTong_Tien_SP += v_objSP.PD_PRICE * v_objBillDetail.BD_QUANTITY;
                        }
                    }

                    //Lấy suất chiếu
                    double v_dblTong_Tien_Ve = 0;

                    tbl_DM_Ticket_DTO v_objTiket = v_objRes.Tiket.FirstOrDefault(it => it.BillID == v_objRes.BL_AutoID);
                    if (v_objTiket != null)
                    {
                        tbl_DM_MovieSchedule_DTO v_objMovieSchedule = v_objMovieSchedule_Bus.GetLastMovieSchedule_ByID(v_objTiket.MovieScheID);
                        if (v_objMovieSchedule_Bus != null)
                        {
                            //Lấy phim
                            tbl_DM_Movie_DTO v_objMovie = v_objMovie_Bus.Find(v_objMovieSchedule.Movie_AutoID);

                            if (v_objMovie != null)
                            {
                                v_dblTong_Tien_Ve = v_objRes.Tiket.Count * v_objMovie.MV_PRICE;
                            }
                        }
                    }

                    if (v_objRes != null)
                    {
                        if ((v_dblTong_Tien_SP + v_dblTong_Tien_Ve) - v_objRes.BL_Total_Price > 0)
                        {
                            frmThanh_Toan v_objForm = new frmThanh_Toan();
                            v_objForm.Set_Data(v_objRes.BL_Bill_Code, (v_dblTong_Tien_SP + v_dblTong_Tien_Ve) - v_objRes.BL_Total_Price);
                            v_objForm.ShowDialog();

                            if (v_objForm.Status_Close == false)
                            {
                                v_objRes.BL_Total_Price += v_objForm.Get_Gia();
                                v_objBill_Bus.UpdateData(v_objRes.BL_AutoID, (int)ETrang_Thai_ID.Hoan_Thanh);
                                v_objBill_Bus.UpdateData(v_objRes.BL_AutoID, v_objRes.BL_Total_Price);

                                Load_Data();

                            }
                        }


                    }
                    selectedBill_AutoID = v_objRes.BL_AutoID;
                }
                IsUsing(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(selectedBill_AutoID != -1)
            {
                // Tạo vé
                RP_InHoaDon report = new RP_InHoaDon();
                report.BindParameter(selectedBill_AutoID.ToString());
                report.CreateDocument();

                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Bills\\") == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Bills\\");

                string predefinedPath = CConfig.CM_Cinema_FileManagement_Folder + "Reports\\Bills\\" + selectedBill_AutoID + ".pdf";
                report.ExportToPdf(predefinedPath); // No Save dialog is triggered

                // Thiết lập máy in
                ReportPrintTool tool = new ReportPrintTool(report);
                if (CCommon.Printer_Name != "")
                    tool.PrinterSettings.PrinterName = CCommon.Printer_Name; // Thay "Tên máy in của bạn" bằng tên máy in thực tế

                // In vé không cần review
                //tool.Print();
                MessageBox.Show("In hóa đơn thành công", "Thông báo");
            }
        }
    }
}
