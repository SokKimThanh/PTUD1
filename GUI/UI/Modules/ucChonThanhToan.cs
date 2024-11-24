using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using DTO.Common;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace GUI.UI.Modules
{
    public partial class ucChonThanhToan : ucBase
    {

        public ucChonThanhToan()
        {
            InitializeComponent();
            lblTitle.Text = "THANH TOÁN";
        }

        protected override void Load_Data()
        {
            //Set up cho cart
            SetupLayoutView();

            //Load trên giao diện
            Load_Danh_Sach_San_Pham();
            Load_Danh_Sach_San_Pham_Chon();

            //Lấy danh sách sản phẩm 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<tbl_DM_Product_DTO> v_arrData = new List<tbl_DM_Product_DTO>();
            grdControl_San_Pham_Da_Chon.DataSource = v_arrData;

            grdData.Columns["PD_AutoID"].Visible = false;
            grdData.Columns["PD_NAME"].Caption = LanguageController.GetLanguageDataLabel("Tên sản phẩm");
            grdData.Columns["PD_IMAGEURL"].Caption = LanguageController.GetLanguageDataLabel("Ảnh");
            grdData.Columns["PD_QUANTITY"].Caption = LanguageController.GetLanguageDataLabel("Số lượng");
            grdData.Columns["PD_PRICE"].Caption = LanguageController.GetLanguageDataLabel("Giá");
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


        #endregion
    }
}
