using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraReports.UI;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using GUI.UI.Component;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucChonThanhToan : ucBase
    {
        private List<tbl_DM_Product_DTO> m_arrSan_Pham_Da_Chon = new List<tbl_DM_Product_DTO>();

        public double Tong_Gia_Ghe { get; set; } = 0;

        private double m_dblTong_Tien = 0;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();

        // Component layout view custom for template card
        CardViewLayoutCustom cardViewLayoutCustom = new CardViewLayoutCustom();

        public ucChonThanhToan()
        {
            InitializeComponent();
            lblTitle.Text = "THANH TOÁN";

            // Ngăn không cho phép chỉnh sửa trực tiếp trên GridView
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

            strFunctionCode = "Thanh toán";

            //Load trên giao diện
            Load_Danh_Sach_San_Pham();

            //Set up cho cart
            SetupLayoutView();

            Load_Danh_Sach_San_Pham_Chon();
            m_dblTong_Tien = Tong_Gia_Ghe;
            txtDanh_Sach_Ten_Ve.Text = string.Join(", ", CCommon.Danh_Sach_Ghe_Da_Chon);
            txtSo_Luong.Text = CCommon.Danh_Sach_Ghe_Da_Chon.Count.ToString();
            txtTong_Tien.Text = m_dblTong_Tien.ToString();
            txtMa_Hoa_Don.Text = "HĐ" + DateTime.Now.ToString("ddMMyyyyhhmmss");

            txtDanh_Sach_Ten_Ve.Enabled = false;
            txtSo_Luong.Enabled = false;
            txtTong_Tien.Enabled = false;
            txtMa_Hoa_Don.Enabled = false;

            grdData.RowClick += RowClick_Grid;

        }

        private void btnThem_San_Pham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonSanPham v_objLoad = new ucChonSanPham();

                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);
                        v_objLoad.Load_DataBase(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear toàn bộ các biến trong common và định tuyến về chọn phim
                CCommon.suatChieuDuocChon = -1;
                CCommon.Danh_Sach_Ghe_Da_Chon = new List<string>();
                CCommon.loaiVeDangDat = -1;


                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonPhim v_objLoad = new ucChonPhim();

                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanh_Toan_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                tbl_DM_Bill_BUS v_objBill_BUS = new tbl_DM_Bill_BUS();
                tbl_DM_Staff_BUS v_objStaff_BUS = new tbl_DM_Staff_BUS();
                try
                {
                    //Tạo obj user 
                    tbl_DM_Staff_DTO v_objStaff = v_objStaff_BUS.GetStaff_ByUserName(CCommon.MaDangNhap);

                    //Tạo hóa đơn
                    tbl_DM_Bill_DTO v_objNewBill = new tbl_DM_Bill_DTO();
                    v_objNewBill.BL_Bill_Code = txtMa_Hoa_Don.Text;
                    v_objNewBill.BL_Total_Price = m_dblTong_Tien;

                    v_objNewBill.BL_STAFF_AutoID = v_objStaff.ST_AutoID;

                    //Nếu là đặt trước thì bill chưa hoàn thành
                    if (CCommon.loaiVeDangDat == 0)
                        v_objNewBill.BL_Trang_Thai_ID = (int)ETrang_Thai_ID.Hoan_Thanh;
                    else
                        v_objNewBill.BL_Trang_Thai_ID = (int)ETrang_Thai_ID.Chua_Hoan_Thanh;

                    v_objNewBill.DELETED = 0;
                    v_objNewBill.CREATED = DateTime.Now;
                    v_objNewBill.CREATED_BY = strActive_User_Name;
                    v_objNewBill.CREATED_BY_FUNCTION = "Thanh toán";
                    v_objNewBill.UPDATED = DateTime.Now;
                    v_objNewBill.UPDATED_BY = strActive_User_Name;
                    v_objNewBill.UPDATED_BY_FUNCTION = "Thanh toán";
                    v_objBill_BUS.AddData(v_objNewBill);

                    //Lấy bill ra
                    tbl_DM_Bill_DTO v_objBill_Res = v_objBill_BUS.Get_Data_By_Code(txtMa_Hoa_Don.Text);

                    if (v_objBill_Res != null)
                    {
                        #region Tính toán dựa trên thực tế
                        //Tạo vé dựa trên sách ghế
                        tbl_DM_Ticket_BUS v_objTicket_BUS = new tbl_DM_Ticket_BUS();

                        foreach (string v_strSeat_Name in CCommon.Danh_Sach_Ghe_Da_Chon)
                        {
                            tbl_DM_Ticket_DTO v_objTiket = new tbl_DM_Ticket_DTO();

                            v_objTiket.SeatName = v_strSeat_Name.Trim();
                            v_objTiket.MovieScheID = CCommon.suatChieuDuocChon;
                            v_objTiket.BillID = v_objBill_Res.BL_AutoID;
                            v_objTiket.StaffID = v_objStaff.ST_AutoID;
                            v_objTiket.Status = CCommon.loaiVeDangDat;
                            v_objTiket.Deleted = 0;
                            v_objTiket.Created = DateTime.Now;
                            v_objTiket.CREATED_BY = strActive_User_Name;
                            v_objTiket.CREATED_BY_FUNCTION = "Thanh toán";
                            v_objTiket.UPDATED = DateTime.Now;
                            v_objTiket.UPDATED_BY = strActive_User_Name;
                            v_objTiket.UPDATED_BY_FUNCTION = "Thanh toán";

                            v_objTicket_BUS.AddData(v_objTiket);
                        }
                        tbl_DM_BillDetail_BUS v_objBillDetail_BUS = new tbl_DM_BillDetail_BUS();

                        //Tạo bill detail dựa trên danh sách sản phẩm đã chọn
                        foreach (tbl_DM_Product_DTO v_objSP_Da_Chon in m_arrSan_Pham_Da_Chon)
                        {
                            //Tạo obj
                            tbl_DM_BillDetail_DTO v_objDetail = new tbl_DM_BillDetail_DTO();
                            v_objDetail.BD_BILL_AutoID = v_objBill_Res.BL_AutoID;
                            v_objDetail.BD_PRODUCT_AutoID = v_objSP_Da_Chon.PD_AutoID;
                            v_objDetail.BD_QUANTITY = v_objSP_Da_Chon.PD_QUANTITY;

                            v_objDetail.DELETED = 0;
                            v_objDetail.CREATED = DateTime.Now;
                            v_objDetail.CREATED_BY = strActive_User_Name;
                            v_objDetail.CREATED_BY_FUNCTION = "Thanh toán";
                            v_objDetail.UPDATED = DateTime.Now;
                            v_objDetail.UPDATED_BY = strActive_User_Name;
                            v_objDetail.UPDATED_BY_FUNCTION = "Thanh toán";

                            v_objBillDetail_BUS.AddData(v_objDetail);
                        }
                        List<tbl_DM_Ticket_DTO> v_arrTiket = v_objTicket_BUS.GetList().Where(it => it.BillID == v_objBill_Res.BL_AutoID).ToList();

                        foreach (tbl_DM_Ticket_DTO v_objItem in v_arrTiket)
                        {
                            try
                            {
                                // Tạo vé
                                RP_PrintTicket report_Ticket = new RP_PrintTicket();
                                report_Ticket.BindParameter(v_objItem.AutoID.ToString());
                                report_Ticket.CreateDocument();

                                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Tickets\\") == false)
                                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Tickets\\");

                                string predefinedPath_Ticket = CConfig.CM_Cinema_FileManagement_Folder + "Reports\\Tickets\\" + v_objItem.AutoID + ".pdf";
                                report_Ticket.ExportToPdf(predefinedPath_Ticket); // No Save dialog is triggered

                                // Thiết lập máy in
                                ReportPrintTool tool_Ticket = new ReportPrintTool(report_Ticket);
                                if (CCommon.Printer_Name != "")
                                    tool_Ticket.PrinterSettings.PrinterName = CCommon.Printer_Name; // Thay "Tên máy in của bạn" bằng tên máy in thực tế

                                // In vé không cần review
                                //tool.Print();

                            }
                            catch (Exception) { }

                        }

                        #endregion
                    }
                    // Tạo vé
                    RP_InHoaDon report_Bill = new RP_InHoaDon();
                    report_Bill.BindParameter(v_objNewBill.BL_AutoID.ToString());
                    report_Bill.CreateDocument();

                    if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                        Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                    if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Bills\\") == false)
                        Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder + "\\Reports\\Bills\\");

                    string predefinedPath_Bill = CConfig.CM_Cinema_FileManagement_Folder + "Reports\\Bills\\" + v_objNewBill.BL_AutoID + ".pdf";
                    report_Bill.ExportToPdf(predefinedPath_Bill); // No Save dialog is triggered

                    // Thiết lập máy in
                    ReportPrintTool tool_Bill = new ReportPrintTool(report_Bill);
                    if (CCommon.Printer_Name != "")
                        tool_Bill.PrinterSettings.PrinterName = CCommon.Printer_Name; // Thay "Tên máy in của bạn" bằng tên máy in thực tế

                    // In vé không cần review
                    //tool.Print();
                    MessageBox.Show("In hóa đơn thành công", "Thông báo");

                    MessageBox.Show(LanguageController.GetLanguageDataLabel("Thanh toán thành công!"), LanguageController.GetLanguageDataLabel("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.None);

                    //Clear toàn bộ các biến trong common và định tuyến về chọn phim
                    CCommon.suatChieuDuocChon = -1;
                    CCommon.Danh_Sach_Ghe_Da_Chon = new List<string>();
                    CCommon.loaiVeDangDat = -1;


                    //Lấy form chứa uc này ra
                    if (this.Parent is FluentDesignFormContainer v_objContainer)
                    {
                        ucChonPhim v_objLoad = new ucChonPhim();

                        if (v_objContainer.Controls.Contains(v_objLoad) == false)
                        {
                            // Clear toàn bộ những gì trên container
                            v_objContainer.Controls.Clear();

                            // Dock control vào container để nó chiếm toàn bộ diện tích
                            v_objLoad.Dock = DockStyle.Fill;

                            // Thêm UserControl vào main container
                            v_objContainer.Controls.Add(v_objLoad);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        #region Nhóm private
        private void Load_Danh_Sach_San_Pham()
        {
            tbl_DM_Product_BUS v_objBus = new tbl_DM_Product_BUS();
            List<tbl_DM_Product_DTO> v_arrData = v_objBus.GetAll();
            gvSanPham.DataSource = v_arrData;
        }

        private void Load_Danh_Sach_San_Pham_Chon()
        {
            grdControl_San_Pham_Da_Chon.DataSource = m_arrSan_Pham_Da_Chon;

            grdData.Columns["PD_AutoID"].Visible = false;
            grdData.Columns["PD_IMAGEURL"].Visible = false;

            grdData.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên sản phẩm");
            grdData.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Ảnh");
            grdData.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            grdData.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");
            grdData.Columns["PD_TRI_GIA"].Caption = LanguageController.GetLanguageDataLabel("Tổng giá");

            FormatGridView(grdData);
        }

        public void SetupLayoutView()
        {
            cardViewLayoutCustom.LayoutView1 = layoutView1;
            cardViewLayoutCustom.GridControl1 = gvSanPham;
            cardViewLayoutCustom.ImageURLFieldName = "PD_IMAGEURL";
            cardViewLayoutCustom.SetupLayoutView();
            cardViewLayoutCustom.AddPhoto();

            // Tìm cột PD_NAME và cấu hình nếu cột tồn tại
            LayoutViewColumn tenSanPham = layoutView1.Columns.ColumnByFieldName("PD_NAME");
            if (tenSanPham != null)
            {
                tenSanPham.Visible = true;
                tenSanPham.Caption = "Tên sản phẩm";
            }
            else
            {
                Console.WriteLine("Cột 'PD_NAME' không tồn tại trong LayoutView.");
            }
            //Thêm sự kiện click 
            layoutView1.MouseDown += ViewCart_MouseDown;
        }

        /// <summary>
        /// Thêm cột hình ảnh khi hiển thị card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "PosterImage" && e.IsGetData)
            {
                // Lấy đường dẫn từ cột MV_POSTERURL của bản ghi hiện tại
                string imagePath = layoutView1.GetRowCellValue(e.ListSourceRowIndex, "PD_IMAGEURL")?.ToString();

                // Kiểm tra nếu file tồn tại
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Đọc hình ảnh từ đường dẫn
                    e.Value = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu không có hình ảnh, sử dụng hình ảnh mặc định
                    e.Value = Properties.Resources.picture_card_no_image;
                }
            }
        }

        //Hàm lấy view cart
        private void ViewCart_MouseDown(object sender, MouseEventArgs e)
        {
            tbl_DM_Product_BUS v_objBus = new tbl_DM_Product_BUS();

            // Lấy thông tin vị trí chuột
            LayoutViewHitInfo v_objMouse_Location = layoutView1.CalcHitInfo(e.Location);

            // Kiểm tra nếu vị trí chuột nằm trên một card
            if (v_objMouse_Location.InCard)
            {
                // Lấy dữ liệu từ ô Auto_ID
                long v_lngSan_Pham_ID = Convert.ToInt64(layoutView1.GetRowCellValue(v_objMouse_Location.RowHandle, "PD_AutoID"));

                //Lấy obj ra
                tbl_DM_Product_DTO v_objSP_Chon = v_objBus.Find(v_lngSan_Pham_ID);

                //Tạo form nhập số lương
                if (v_objSP_Chon != null)
                {
                    frmNhap_SL v_objFormSL = new frmNhap_SL();
                    v_objFormSL.Set_Data(v_objSP_Chon.PD_NAME);
                    v_objFormSL.ShowDialog();
                    if (v_objFormSL.Status_Close == false)
                    {
                        v_objSP_Chon.PD_QUANTITY = v_objFormSL.Get_SL();
                        if (v_objSP_Chon.PD_QUANTITY > 0)
                            m_arrSan_Pham_Da_Chon.Add(v_objSP_Chon);
                        grdData.RefreshData();

                        //Cập nhật tổng tiền
                        m_dblTong_Tien = Tong_Gia_Ghe + m_arrSan_Pham_Da_Chon.Sum(it => it.PD_TRI_GIA);
                        txtTong_Tien.Text = m_dblTong_Tien.ToString();
                    }
                }
            }
        }

        // Hàm để lấy hình ảnh từ dữ liệu (cần tùy chỉnh theo ứng dụng thực tế)
        private Image GetImageByRowHandle(int p_iRowHandle)
        {
            // Ví dụ: Tải hình ảnh từ cơ sở dữ liệu hoặc URL
            string v_strImage_Url = layoutView1.GetRowCellValue(p_iRowHandle, "PD_IMAGEURL")?.ToString();
            // Kiểm tra nếu file tồn tại
            if (string.IsNullOrEmpty(v_strImage_Url) == false && File.Exists(v_strImage_Url))
            {
                // Đọc hình ảnh từ đường dẫn
                return Image.FromFile(v_strImage_Url);
            }
            return null; // Nếu không có hình ảnh, trả về null
        }

        protected override void ObjectProcessing(object obj)
        {
            tbl_DM_Product_DTO v_objSP_Da_Chon = obj as tbl_DM_Product_DTO;

            //Tạo form nhập số lương
            if (v_objSP_Da_Chon != null)
            {
                frmNhap_SL v_objFormSL = new frmNhap_SL();
                v_objFormSL.Set_Data(v_objSP_Da_Chon.PD_NAME, v_objSP_Da_Chon.PD_QUANTITY);
                v_objFormSL.ShowDialog();
                if (v_objFormSL.Status_Close == false)
                {
                    v_objSP_Da_Chon.PD_QUANTITY = v_objFormSL.Get_SL();
                    if (v_objSP_Da_Chon.PD_QUANTITY == 0)
                    {
                        tbl_DM_Product_DTO v_objRemove = m_arrSan_Pham_Da_Chon.FirstOrDefault(it => it.PD_AutoID == v_objSP_Da_Chon.PD_AutoID);
                        m_arrSan_Pham_Da_Chon.Remove(v_objRemove);
                    }
                    grdData.RefreshData();

                    //Cập nhật tổng tiền

                    m_dblTong_Tien = Tong_Gia_Ghe + m_arrSan_Pham_Da_Chon.Sum(it => it.PD_TRI_GIA);
                    txtTong_Tien.Text = m_dblTong_Tien.ToString();
                }
            }
        }

        #endregion
    }
}
