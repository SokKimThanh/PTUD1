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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Set the card's minimum size.
            viewCart.CardMinSize = new Size(300, 350);

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên Layoutview
            viewCart.OptionsBehavior.Editable = false;

            // Duyệt qua tất cả các cột và ẩn các cột không cần thiết
            foreach (LayoutViewColumn v_objCol in viewCart.Columns)
            {
                // ẩn tất cả cột không cần thiết
                v_objCol.Visible = false;

                // tắt cái tiêu đề của field
                v_objCol.LayoutViewField.TextVisible = false;
            }

            // Tạo cột hình ảnh không có sẵn trong dữ liệu (Unbound)
            LayoutViewColumn v_objImg_Col = viewCart.Columns.AddField("PD_IMAGEURL");
            // tắt cái tiêu đề của field
            v_objImg_Col.LayoutViewField.TextVisible = false;
            v_objImg_Col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            v_objImg_Col.Visible = true;
            v_objImg_Col.Caption = "Hình ảnh";

            // Thiết lập LayoutViewField cho cột hình ảnh
            LayoutViewField v_objLayout_Field = v_objImg_Col.LayoutViewField;
            v_objLayout_Field.TextVisible = false;
            v_objLayout_Field.SizeConstraintsType = SizeConstraintsType.Default;

            // Thiết lập RepositoryItemPictureEdit để hiển thị hình ảnh
            RepositoryItemPictureEdit v_objPicture = new RepositoryItemPictureEdit();
            v_objPicture.SizeMode = PictureSizeMode.Zoom; // Thử chế độ Zoom thay vì Squeeze
            v_objPicture.PictureAlignment = ContentAlignment.MiddleCenter; // Căn giữa hình ảnh
            grdControl_San_Pham.RepositoryItems.Add(v_objPicture);
            v_objImg_Col.ColumnEdit = v_objPicture;

            // Tìm cột PD_IMAGEURL và cấu hình nếu cột tồn tại
            LayoutViewColumn v_objCol_Res = viewCart.Columns.ColumnByFieldName("PD_IMAGEURL");
            if (v_objCol_Res != null)
            {
                v_objCol_Res.Visible = true;
                v_objCol_Res.Caption = "Tên sản phẩm";
            }
        }

        #endregion
    }
}
