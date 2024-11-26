using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DTO.tbl_DTO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using DTO.Common;
using System.Linq;
using GUI.UI.Component;
using DevExpress.XtraExport.Helpers;

namespace GUI.UI.Modules
{
    public partial class ucHoaDon : ucBase
    {
        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
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

        protected override void Update_Data()
        {
            tbl_DM_Bill_BUS v_objBill_Bus = new tbl_DM_Bill_BUS();
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


                    // Lấy tiền của hóa đơn
                    double v_dblPrice = v_objRes.BL_Total_Price;

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
                                v_objBill_Bus.UpdateData(v_objRes.BL_AutoID, v_objRes.BL_Total_Price);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
