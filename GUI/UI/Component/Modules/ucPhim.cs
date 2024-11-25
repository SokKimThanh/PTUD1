using BUS;
using BUS.Danh_Muc;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucPhim : ucBase
    {
        private tbl_DM_AgeRating_BUS cboAgeRatingData = new tbl_DM_AgeRating_BUS();
        private tbl_DM_Movie_BUS data = new tbl_DM_Movie_BUS();

        private string dgv_selected_id = "";
        private long? cboAgeRating_selected_id = -1;// giá trị từ ComboBoxEdit
        private string txtUrlHinhAnh = "";


        // Từ điển cache hình ảnh
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        public ucPhim()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lấy dữ liệu từ form
        /// </summary>
        /// <returns></returns>
        private tbl_DM_Movie_DTO GetFormData()
        {
            // Sử dụng constructor của tbl_DM_Movie_DTO để tạo đối tượng movie
            var movie = new tbl_DM_Movie_DTO();
            movie.MV_NAME = txtName.Text;
            movie.MV_POSTERURL = txtUrlHinhAnh;
            movie.MV_DESCRIPTION = txtDescription.Text;
            movie.MV_PRICE = double.Parse(txtPrice.Text.Trim());
            movie.MV_DURATION = int.Parse(txtDurations.Text.Trim());
            // edit selected id on datagridview
            if (dgv_selected_id != "")
            {
                movie.MV_AutoID = long.Parse(dgv_selected_id);
            }
            movie.MV_AGERATING_AutoID = cboAgeRating_selected_id;

            return movie;
        }

        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            // tai du lieu danh gia do tuoi
            List<tbl_DM_AgeRating_DTO> ageRatingList = cboAgeRatingData.GetAll();
            // Thêm các mục vào ComboBoxEdit thông qua Properties.Items
            cboAgeRating.Properties.DataSource = cboAgeRatingData.GetCombobox();
            cboAgeRating.Properties.DisplayMember = "AR_NAME";
            cboAgeRating.Properties.ValueMember = "AR_AutoID";
            cboAgeRating.ItemIndex = -1;
            //cboAgeRating.Properties.Columns.Add(new LookUpColumnInfo("AR_AutoID", "ID", 50)); // Cột ID
            cboAgeRating.Properties.Columns.Add(new LookUpColumnInfo("AR_NAME", "Tên Đánh Giá", 100)); // Cột Tên Đánh Giá
            cboAgeRating.Properties.Columns.Add(new LookUpColumnInfo("AR_NOTE", "Ghi Chú", 150)); // Cột Ghi Chú

            // tai du lieu dgv
            ClearImageCache();
            dgv.DataSource = data.GetAll();
            dgv.RefreshDataSource();

            // Đặt chiều cao dòng phù hợp với kích thước của hình ảnh
            gridView1.RowHeight = 150;

            var width_img = 100;
            // đặt chiều rộng cột hình ảnh
            gridView1.Columns["MV_POSTERURL"].Width = width_img;

            // Đặt độ rộng tối thiểu và tối đa cho một cột cụ thể
            gridView1.Columns["MV_POSTERURL"].MinWidth = width_img;
            gridView1.Columns["MV_POSTERURL"].MaxWidth = width_img;

            // Vẽ thủ công hình ảnh hiển thị trên lưới 
            gridView1.CustomDrawCell += gridView1_CustomDrawCell;

            // Đặt tên tiếng Việt cho các cột
            gridView1.Columns["MV_NAME"].Caption = "Tên Phim";
            gridView1.Columns["MV_PRICE"].Caption = "Giá";
            gridView1.Columns["MV_DESCRIPTION"].Caption = "Mô tả";
            gridView1.Columns["MV_DURATION"].Caption = "Thời lượng (Phút)";
            gridView1.Columns["MV_POSTERURL"].Caption = "Đường dẫn Hình ảnh";
            gridView1.Columns["MV_AutoID"].Visible = false;
            gridView1.Columns["MV_AGERATING_AutoID"].Visible = false;

            // Đặt VisibleIndex của cột MV_POSTERURL về 0 để chuyển nó lên vị trí đầu tiên
            gridView1.Columns["MV_POSTERURL"].VisibleIndex = 0;
        }
        /// <summary>
        /// Thêm mới movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbl_DM_Movie_DTO movie = GetFormData();

                if (data.Add(movie) != 0)
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
        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Làm mới dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        dgv_selected_id = gridView1.GetRowCellValue(i, "MV_AutoID").ToString().Trim();
                        tbl_DM_Movie_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtName.Text = o.MV_NAME;
                        txtDescription.Text = o.MV_DESCRIPTION;
                        txtDurations.Text = o.MV_DURATION.ToString();
                        txtUrlHinhAnh = o.MV_POSTERURL;
                        txtPrice.Text = o.MV_PRICE.ToString();
                        // Hiển thị dữ liệu lên combobox
                        cboAgeRating.EditValue = o.MV_AGERATING_AutoID;
                        // Hiển thị hình ảnh trên PictureEdit
                        try
                        {
                            Image image = Image.FromFile(o.MV_POSTERURL);
                            pictureBox.Image = image;
                        }
                        catch (Exception)
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
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDurations.Text = string.Empty;
            txtUrlHinhAnh = string.Empty;
            txtPrice.Text = string.Empty;
            cboAgeRating.EditValue = null;
            pictureBox.Image = null;
        }

        private void cboAgeRating_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboAgeRating.EditValue != null)
            {
                cboAgeRating_selected_id = long.Parse(cboAgeRating.EditValue.ToString().Trim());
            }
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


        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "MV_POSTERURL")
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
