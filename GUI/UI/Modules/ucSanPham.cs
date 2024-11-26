using BUS.Danh_Muc;
using DTO.Common;
using DTO.tbl_DTO;
using GUI.UI.Component;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucSanPham : ucBase
    {
        private tbl_DM_Product_BUS data = new tbl_DM_Product_BUS();
        private tbl_DM_ExpenseType_BUS expenseType_BUS = new tbl_DM_ExpenseType_BUS();
        private string dgv_selected_id = "";
        private string txtUrlHinhAnh = "";
        private double txtSoLuong = 0;

        // Từ điển cache hình ảnh
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
        public ucSanPham()
        {
            InitializeComponent();

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(gridView1);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }
        /// <summary>
        /// Lấy dữ liệu từ form
        /// </summary>
        /// <returns></returns>
        private tbl_DM_Product_DTO GetFormData()
        {
            // Sử dụng constructor của tbl_DM_Product_DTO để tạo đối tượng productBUS
            var product = new tbl_DM_Product_DTO();
            product.PD_NAME = txtTenSanPham.Text.Trim();
            product.PD_PRICE = double.Parse(txtGiaBan.Text.ToString().Trim());
            product.PD_IMAGEURL = txtUrlHinhAnh.Trim();
            product.PD_QUANTITY = txtSoLuong;
            // edit selected id on datagridview
            if (dgv_selected_id != "")
            {
                product.PD_AutoID = long.Parse(dgv_selected_id);
            }

            return product;
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
            // tai du lieu dgv
            ClearImageCache();
            dgv.DataSource = data.GetAll();
            dgv.RefreshDataSource();

            // Đặt chiều cao dòng phù hợp với kích thước của hình ảnh
            gridView1.RowHeight = 150;

            var width_img = 100;
            // đặt chiều rộng cột hình ảnh
            gridView1.Columns["PD_IMAGEURL"].Width = width_img;

            // Đặt độ rộng tối thiểu và tối đa cho một cột cụ thể
            gridView1.Columns["PD_IMAGEURL"].MinWidth = width_img;
            gridView1.Columns["PD_IMAGEURL"].MaxWidth = width_img;

            // Vẽ thủ công hình ảnh hiển thị trên lưới 
            gridView1.CustomDrawCell += gridView1_CustomDrawCell;

            // Đặt tên tiếng Việt cho các cột
            gridView1.Columns["PD_NAME"].Caption = "Tên sản phẩm";
            gridView1.Columns["PD_PRICE"].Caption = "Giá tiền";
            gridView1.Columns["PD_QUANTITY"].Caption = "Số lượng đang có";
            gridView1.Columns["PD_IMAGEURL"].Caption = "Đường dẫn Hình Ảnh";
            gridView1.Columns["PD_AutoID"].Visible = false;

            // Đặt VisibleIndex của cột PD_IMAGEURL về 0 để chuyển nó lên vị trí đầu tiên
            gridView1.Columns["PD_IMAGEURL"].VisibleIndex = 0;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbl_DM_Product_DTO product = GetFormData();
                tbl_DM_ExpenseType_DTO expenseType = GetFormExpenseTypeData();
                if (data.Add(product) != 0 && expenseType_BUS.Add(expenseType) != 0)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    LoadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        private tbl_DM_ExpenseType_DTO GetFormExpenseTypeData()
        {
            // Sử dụng constructor của tbl_DM_Product_DTO để tạo đối tượng productBUS
            var expenseType = new tbl_DM_ExpenseType_DTO();
            expenseType.ET_NAME = "Nhập: " + txtTenSanPham.Text.Trim();
            expenseType.CREATED = DateTime.Now;
            expenseType.CREATED_BY = CCommon.MaDangNhap;
            expenseType.UPDATED_BY = CCommon.MaDangNhap;
            expenseType.UPDATED = DateTime.Now;
            expenseType.CREATED_BY_FUNCTION = "GetFormExpenseTypeData";
            expenseType.UPDATED_BY_FUNCTION = "GetFormExpenseTypeData";

            return expenseType;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    data.Remove(long.Parse(dgv_selected_id));
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
        }
        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                data.Update(GetFormData());
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo");
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
            Load_Data();
        }
        private void dgv_Click(object sender, EventArgs e)
        {
            int[] dong = gridView1.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        dgv_selected_id = gridView1.GetRowCellValue(i, "PD_AutoID").ToString().Trim();
                        tbl_DM_Product_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtTenSanPham.Text = o.PD_NAME;
                        txtGiaBan.Text = o.PD_PRICE.ToString();
                        txtUrlHinhAnh = o.PD_IMAGEURL;
                        txtSoLuong = o.PD_QUANTITY;
                        try
                        {
                            Image image = Image.FromFile(o.PD_IMAGEURL);
                            pictureBox.Image = image;
                        }
                        catch
                        {
                            // Nếu file không tồn tại, sử dụng hình từ Resources
                            pictureBox.Image = Properties.Resources.picture_box_no_image;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }
        // Cập nhật trạng thái các nút thao tác
        private void dangThaoTac(bool isEdit)
        {
            btnThem.Enabled = !isEdit;
            btnCapNhat.Enabled = isEdit;
            btnXoa.Enabled = isEdit;
        }

        // Load dữ liệu và thiết lập form mặc định
        public void LoadForm()
        {
            dgv.DataSource = data.GetAll();
            dangThaoTac(false);
            txtTenSanPham.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            pictureBox.Image = null;
        }


        /// <summary>
        /// Chọn hình ảnh bằng cách nhấp vào nút chọn hình ảnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            ChonHinhAnh();
        }
        /// <summary>
        /// Chọn hình ảnh bằng cách nhấp vào khung hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            ChonHinhAnh();
        }

        /// <summary>
        /// Chọn một hình ảnh không vượt qua 500kb
        /// </summary>
        private void ChonHinhAnh()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtUrlHinhAnh = openFileDialog.FileName;

                // Kiểm tra kích thước file
                FileInfo fileInfo = new FileInfo(txtUrlHinhAnh);
                if (fileInfo.Length > 500 * 1024) // 500 KB
                {
                    MessageBox.Show(
                        "Hình ảnh vượt quá 500 KB. Vui lòng chọn hình ảnh có kích thước nhỏ hơn.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtUrlHinhAnh = string.Empty; // Xóa giá trị nếu file không hợp lệ
                }
                else
                {
                    // Hiển thị hình ảnh nếu kích thước hợp lệ
                    pictureBox.Image = Image.FromFile(txtUrlHinhAnh);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "PD_IMAGEURL")
            {
                string imagePath = gridView1.GetRowCellValue(e.RowHandle, e.Column)?.ToString();

                Image img;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Kiểm tra cache
                    if (!imageCache.TryGetValue(imagePath, out img))
                    {
                        // Nếu hình ảnh chưa có trong cache, tạo mới
                        img = Image.FromFile(imagePath);
                        Image resizedImg = ResizeImage(img, e.Bounds.Width);

                        // Lưu hình ảnh đã resize vào cache
                        imageCache[imagePath] = resizedImg;

                        // Giải phóng hình ảnh gốc
                        img.Dispose();
                        img = resizedImg;
                    }
                }
                else
                {
                    // Sử dụng hình ảnh mặc định, không cần cache
                    img = Properties.Resources.gridview_no_image;
                }

                // Vẽ hình ảnh từ cache hoặc mặc định
                e.Graphics.DrawImage(img, e.Bounds);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Resize theo chiều ngang, giữ tỷ lệ dọc
        /// </summary>
        /// <param name="img"></param>
        /// <param name="targetWidth"></param>
        /// <returns></returns>
        private Image ResizeImage(Image img, int targetWidth)
        {
            // Tính toán chiều cao mới dựa trên tỷ lệ
            int originalWidth = img.Width;
            int originalHeight = img.Height;
            float scale = (float)targetWidth / originalWidth; // Tỷ lệ chiều ngang
            int targetHeight = (int)(originalHeight * scale); // Chiều cao giữ tỷ lệ

            // Tạo một hình ảnh mới với kích thước tính toán
            Bitmap resizedImg = new Bitmap(targetWidth, targetHeight);
            using (Graphics g = Graphics.FromImage(resizedImg))
            {
                // Đảm bảo chất lượng khi resize
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, targetWidth, targetHeight);
            }
            return resizedImg;
        }
        /// <summary>
        /// xóa cache từ điển
        /// </summary>
        private void ClearImageCache()
        {
            foreach (var img in imageCache.Values)
            {
                img.Dispose(); // Giải phóng tài nguyên hình ảnh
            }
            imageCache.Clear();
        }
    }
}
