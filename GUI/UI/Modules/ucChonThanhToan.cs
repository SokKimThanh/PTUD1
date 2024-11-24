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

namespace GUI.UI.Modules
{
    public partial class ucChonThanhToan : ucBase
    {
        tbl_DM_Product_BUS v_objBus = new tbl_DM_Product_BUS();

        public ucChonThanhToan()
        {
            InitializeComponent();
            lblTitle.Text = "THANH TOÁN";
        }

        protected override void Load_Data()
        {
            

            //Load trên giao diện
            Load_Danh_Sach_San_Pham(); 

            //Set up cho cart
            SetupLayoutView();

            //Lấy danh sách sản phẩm 
            Load_Danh_Sach_San_Pham_Chon();

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
            gvSanPham.DataSource = v_objBus.GetAll();
            gvSanPham.RefreshDataSource();
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
            layoutView1.CardMinSize = new Size(300, 350);
            layoutView1.OptionsCustomization.AllowFilter = false;
            layoutView1.OptionsCustomization.ShowGroupView = false;

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên Layoutview
            layoutView1.OptionsBehavior.Editable = false;

            // Duyệt qua tất cả các cột và ẩn các cột không cần thiết
            foreach (LayoutViewColumn column in layoutView1.Columns)
            {
                // ẩn tất cả cột không cần thiết
                column.Visible = false;

                // tắt cái tiêu đề của field
                column.LayoutViewField.TextVisible = false;
            }

            // Tạo cột hình ảnh không có sẵn trong dữ liệu (Unbound)
            LayoutViewColumn hinhAnhColumn = layoutView1.Columns.AddField("PosterImage");
            // tắt cái tiêu đề của field
            hinhAnhColumn.LayoutViewField.TextVisible = false;
            hinhAnhColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            hinhAnhColumn.Visible = true;
            hinhAnhColumn.Caption = "Hình ảnh";

            // Thiết lập LayoutViewField cho cột hình ảnh
            LayoutViewField hinhAnhField = hinhAnhColumn.LayoutViewField;
            hinhAnhField.TextVisible = false;
            hinhAnhField.SizeConstraintsType = SizeConstraintsType.Custom;
            hinhAnhField.MinSize = new Size(300, 350); // Minimum size of the card
            hinhAnhField.MaxSize = new Size(300, 350); // Maximum size of the card
            hinhAnhField.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0); // Remove any padding

            // Thiết lập RepositoryItemPictureEdit để hiển thị hình ảnh
            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
            pictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze; // Stretch to fit
            pictureEdit.PictureAlignment = ContentAlignment.MiddleCenter; // Center the image
            gvSanPham.RepositoryItems.Add(pictureEdit);
            hinhAnhColumn.ColumnEdit = pictureEdit;

            // Tìm cột PD_NAME và cấu hình nếu cột tồn tại
            LayoutViewColumn tenSanPham = layoutView1.Columns.ColumnByFieldName("PD_NAME");
            if (tenSanPham != null)
            {
                tenSanPham.Visible = true;
                tenSanPham.Caption = "Tên phim";
            }
            else
            {
                Console.WriteLine("Cột 'PD_NAME' không tồn tại trong LayoutView.");
            }
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

        #endregion
    }
}
