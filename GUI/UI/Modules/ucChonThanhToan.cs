using BUS.Bao_Cao;
using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraLayout;
using DevExpress.XtraReports.UI;
using DTO.Common;
using DTO.tbl_DTO;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace GUI.UI.Modules
{
    public partial class ucChonThanhToan : ucBase
    {
        private List<tbl_DM_Product_DTO> m_arrSan_Pham_Da_Chon = new List<tbl_DM_Product_DTO>();

        public double Tong_Gia_Ghe { get; set; } = 0;

        private double m_dblTong_Tien = 0;

        public ucChonThanhToan()
        {
            InitializeComponent();
            lblTitle.Text = "THANH TOÁN";
        }

        protected override void Load_Data()
        {
            //Set up cho cart
            SetupLayoutView();
            strFunctionCode = "Thanh toán";
            //Load trên giao diện
            Load_Danh_Sach_San_Pham();
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

                    v_objNewBill.DELETED = 0;
                    v_objNewBill.CREATED = DateTime.Now;
                    v_objNewBill.CREATED_BY = strActive_User_Name;
                    v_objNewBill.CREATED_BY_FUNCTION = strFunctionCode;
                    v_objNewBill.UPDATED = DateTime.Now;
                    v_objNewBill.UPDATED_BY = strActive_User_Name;
                    v_objNewBill.UPDATED_BY_FUNCTION = strFunctionCode;
                    v_objBill_BUS.AddData(v_objNewBill);

                    //Lấy bill ra
                    tbl_DM_Bill_DTO v_objBill_Res = v_objBill_BUS.Get_Data_By_Code(txtMa_Hoa_Don.Text);

                    if (v_objBill_Res != null)
                    {
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
                            v_objTiket.CREATED_BY_FUNCTION = strFunctionCode;
                            v_objTiket.UPDATED = DateTime.Now;
                            v_objTiket.UPDATED_BY = strActive_User_Name;
                            v_objTiket.UPDATED_BY_FUNCTION = strFunctionCode;

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
                            v_objDetail.CREATED_BY_FUNCTION = strFunctionCode;
                            v_objDetail.UPDATED = DateTime.Now;
                            v_objDetail.UPDATED_BY = strActive_User_Name;
                            v_objDetail.UPDATED_BY_FUNCTION = strFunctionCode;

                            v_objBillDetail_BUS.AddData(v_objDetail);
                        }
                        List<tbl_DM_Ticket_DTO> v_arrTiket = v_objTicket_BUS.GetList().Where(it => it.BillID == v_objBill_Res.BL_AutoID).ToList();

                        foreach (tbl_DM_Ticket_DTO v_objItem in v_arrTiket)
                        {
                            // Tạo vé
                            RP_PrintTicket report = new RP_PrintTicket();
                            report.BindParameter(v_objItem.AutoID.ToString());
                            report.CreateDocument();

                            // Thiết lập máy in
                            ReportPrintTool tool = new ReportPrintTool(report);
                            if (CCommon.Printer_Name != "")
                                tool.PrinterSettings.PrinterName = CCommon.Printer_Name; // Thay "Tên máy in của bạn" bằng tên máy in thực tế

                            // In vé không cần review
                            tool.Print();
                        }

                    }

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
            grdControl_San_Pham.DataSource = v_arrData;
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
            // Thiết lập kích thước tối thiểu cho card
            viewCart.CardMinSize = new Size(300, 350);

            // Ngăn không cho phép sửa dữ liệu trực tiếp
            viewCart.OptionsBehavior.Editable = false;

            // Ẩn tất cả các cột mặc định
            foreach (LayoutViewColumn v_objCol in viewCart.Columns)
            {
                v_objCol.Visible = false;
                v_objCol.LayoutViewField.TextVisible = false;
            }

            // Tạo cột hiển thị hình ảnh (Unbound Column)
            LayoutViewColumn v_objImage_Col = new LayoutViewColumn
            {
                FieldName = "PD_IMAGEURL",
                Caption = "Hình ảnh",
                Visible = true,
                UnboundType = DevExpress.Data.UnboundColumnType.Object
            };

            // Thiết lập RepositoryItemPictureEdit để hiển thị hình ảnh
            RepositoryItemPictureEdit v_objPicture = new RepositoryItemPictureEdit
            {
                SizeMode = PictureSizeMode.Zoom,
                PictureAlignment = ContentAlignment.MiddleCenter
            };
            grdControl_San_Pham.RepositoryItems.Add(v_objPicture);
            v_objImage_Col.ColumnEdit = v_objPicture;

            // Thêm cột vào LayoutView
            viewCart.Columns.Add(v_objImage_Col);

            // Tùy chỉnh sự kiện CustomUnboundColumnData để gán giá trị hình ảnh
            viewCart.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "PD_IMAGEURL" && e.IsGetData)
                {
                    // Thay thế GetImageByRowHandle bằng logic của bạn để lấy hình ảnh
                    e.Value = GetImageByRowHandle(e.ListSourceRowIndex);
                }
            };

            // Cấu hình thêm các cột khác (ví dụ: tên sản phẩm)
            LayoutViewColumn v_objCol_Name = viewCart.Columns.ColumnByFieldName("PD_NAME");
            if (v_objCol_Name != null)
            {
                v_objCol_Name.Visible = true;
                v_objCol_Name.Caption = "Tên sản phẩm";
                v_objCol_Name.LayoutViewField.TextVisible = true;
            }

            //Thêm sự kiện click 
            viewCart.MouseDown += ViewCart_MouseDown;
        }

        //Hàm lấy view cart
        private void ViewCart_MouseDown(object sender, MouseEventArgs e)
        {
            tbl_DM_Product_BUS v_objBus = new tbl_DM_Product_BUS();

            // Lấy thông tin vị trí chuột
            LayoutViewHitInfo v_objMouse_Location = viewCart.CalcHitInfo(e.Location);

            // Kiểm tra nếu vị trí chuột nằm trên một card
            if (v_objMouse_Location.InCard)
            {
                // Lấy dữ liệu từ ô Auto_ID
                long v_lngSan_Pham_ID = Convert.ToInt64(viewCart.GetRowCellValue(v_objMouse_Location.RowHandle, "PD_AutoID"));

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
                        m_arrSan_Pham_Da_Chon.Add(v_objSP_Chon);
                        grdData.RefreshData();

                        //Cập nhật tổng tiền
                        m_dblTong_Tien = Tong_Gia_Ghe + v_objSP_Chon.PD_TRI_GIA;
                        txtTong_Tien.Text = m_dblTong_Tien.ToString();
                    }
                }
            }
        }

        // Hàm để lấy hình ảnh từ dữ liệu (cần tùy chỉnh theo ứng dụng thực tế)
        private Image GetImageByRowHandle(int p_iRowHandle)
        {
            // Ví dụ: Tải hình ảnh từ cơ sở dữ liệu hoặc URL
            string v_strImage_Url = viewCart.GetRowCellValue(p_iRowHandle, "PD_IMAGEURL")?.ToString();
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
                    grdData.RefreshData();

                    //Cập nhật tổng tiền
                    m_dblTong_Tien = Tong_Gia_Ghe + v_objSP_Da_Chon.PD_TRI_GIA;
                    txtTong_Tien.Text = m_dblTong_Tien.ToString();
                }
            }
        }

        #endregion
    }
}
