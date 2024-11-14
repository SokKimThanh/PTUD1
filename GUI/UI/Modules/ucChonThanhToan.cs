using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DTO.Common;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucChonThanhToan : ucBase
    {
        public string[] Danh_Sach_Ten_Ghe
        {
            get;
            set;
        } = new string[0];

        public List<tbl_DM_Product_DTO> Danh_Sach_San_Pham { get; set; } = new List<tbl_DM_Product_DTO>();

        public double Tong_Tien_Ghe
        {
            get;
            set;
        } = 0;

        public double Tong_Tien_San_Pham
        {
            get;
            set;
        } = 0;

        private List<tbl_DM_Ticket_DTO> m_arrGhes = new List<tbl_DM_Ticket_DTO>();

        private tbl_DM_Staff_DTO v_objUser = new tbl_DM_Staff_DTO();

        public ucChonThanhToan()
        {
            InitializeComponent();
            lblTitle.Text = "Thanh toán".ToUpper();
        }

        protected override void Load_Data()
        {
            tbl_DM_Staff_BUS v_objStaff_BUS = new tbl_DM_Staff_BUS();
            List<tbl_DM_Staff_DTO> v_arrStaff = v_objStaff_BUS.ListData();

            //txtTong_Tien.Text = (Tong_Tien_Ghe + Tong_Tien_San_Pham).ToString();

            //Lấy obj staff
            v_objUser = v_objStaff_BUS.GetStaff_ByUserName(CCommon.MaDangNhap);

            //Tạo danh sách ghês 
            m_arrGhes.Clear();
            for (int i = 0; i < Danh_Sach_Ten_Ghe.Length; i++)
            {
                tbl_DM_Ticket_DTO v_objGhe = new tbl_DM_Ticket_DTO();
                v_objGhe.SeatName = Danh_Sach_Ten_Ghe[i];
                v_objGhe.MovieScheID = CCommon.suatChieuDuocChon;
                v_objGhe.StaffID = v_objUser.ST_AutoID;
                m_arrGhes.Add(v_objGhe);
            }

            //Lưới ghế
            //gridControl1.DataSource = m_arrGhes;
            //grdGhe.Columns["AutoID"].Visible = false;
            //grdGhe.Columns["StaffID"].Visible = false;
            //grdGhe.Columns["MovieScheID"].Visible = false;
            //grdGhe.Columns["Deleted"].Visible = false;
            //grdGhe.Columns["SeatName"].Caption = LanguageController.GetLanguageDataLabel("Tên ghế");
            //FormatGridView(grdGhe);

            //Lưới sản phẩm
            //gridControl2.DataSource = Danh_Sach_San_Pham;
            //grdSan_Pham.Columns["PD_AutoID"].Visible = false;
            //grdSan_Pham.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên");
            //grdSan_Pham.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Hình ảnh");
            //grdSan_Pham.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            //grdSan_Pham.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");
            //FormatGridView(grdSan_Pham);

            //txtMaHoaDon.Text = "HD" + DateTime.Now.ToString("ddMMyyyyHHmmss");

            //txtNgayHoaDon.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //txtNhanVien.Text = v_objUser.ST_USERNAME;
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

                        v_objLoad.Danh_Sach_Ten_Ghe = Danh_Sach_Ten_Ghe;
                        v_objLoad.Tong_Tien_Ghe = Tong_Tien_Ghe;

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

                        v_objLoad.Load_DataBase(sender, e);
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
            try
            {
                tbl_DM_Bill_BUS v_objBillBus = new tbl_DM_Bill_BUS();

                tbl_DM_Ticket_BUS v_objTiket_BUs = new tbl_DM_Ticket_BUS();

                //Tạo hóa đơn cho sản phẩm
                foreach (tbl_DM_Product_DTO v_objProduct in Danh_Sach_San_Pham)
                {
                    //Tạo obj bill
                    tbl_DM_Bill_DTO v_objBillDTO = new tbl_DM_Bill_DTO();
                    v_objBillDTO.BL_PRODUCT_AutoID = v_objProduct.PD_AutoID;
                    v_objBillDTO.BL_STAFF_AutoID = v_objUser.ST_AutoID;
                    v_objBillDTO.BL_QUANTITY = v_objProduct.PD_QUANTITY;
                    v_objBillDTO.BL_PRICE = v_objProduct.PD_PRICE;
                    v_objBillDTO.DELETED = 0;
                    v_objBillDTO.CREATED = DateTime.Now;
                    v_objBillDTO.UPDATED = DateTime.Now;
                    v_objBillDTO.CREATED_BY = v_objUser.ST_USERNAME;
                    v_objBillDTO.UPDATED_BY = v_objUser.ST_USERNAME;
                    v_objBillDTO.CREATED_BY_FUNCTION = "Thanh toán";
                    v_objBillDTO.UPDATED_BY_FUNCTION = "Thanh toán";

                    v_objBillBus.AddData(v_objBillDTO);

                }

                //Tạo hóa đơn vé;
                foreach (tbl_DM_Ticket_DTO v_objTiket in m_arrGhes)
                {
                    v_objTiket_BUs.AddData(v_objTiket);
                }

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

                        v_objLoad.Load_DataBase(sender, e);
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
