using BUS;
using BUS.Danh_Muc;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            movie.MV_POSTERURL = txtUrlHinhAnh.Text;
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
                        txtUrlHinhAnh.Text = o.MV_POSTERURL;
                        txtPrice.Text = o.MV_PRICE.ToString();
                        // Hiển thị dữ liệu lên combobox
                        cboAgeRating.EditValue = o.MV_AGERATING_AutoID;
                        // Hiển thị hình ảnh trên PictureEdit
                        try
                        {
                            Image image = Image.FromFile(o.MV_POSTERURL);
                            pictureBox.Image = image;
                        }
                        catch
                        {
                            // Nếu file không tồn tại, sử dụng hình từ Resources
                            // Tên 'no_image_256' là tên của hình trong Resources
                            pictureBox.Image = Properties.Resources.no_image_256;
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
            txtUrlHinhAnh.Text = string.Empty;
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
        /// Nhấp vào hình hiển thị dialog box chọn ảnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị hình ảnh trên PictureEdit
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);

                // Lấy đường dẫn đầy đủ của file đã chọn
                string selectedMV_POSTERURL = openFileDialog.FileName;

                // Hiển thị đường dẫn hình ảnh
                txtUrlHinhAnh.Text = selectedMV_POSTERURL;
            }
        }

        /// <summary>
        /// Nút thêm hình nếu người dùng thích bấm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị hình ảnh trên PictureEdit
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);

                // Lấy đường dẫn đầy đủ của file đã chọn
                string selectedMV_POSTERURL = openFileDialog.FileName;

                // Hiển thị đường dẫn hình ảnh trong TextBox hoặc Label
                txtUrlHinhAnh.Text = selectedMV_POSTERURL;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Kiểm tra nếu cột hiện tại là cột chứa đường dẫn hình ảnh
            if (e.Column.FieldName == "MV_POSTERURL")
            {
                // Lấy đường dẫn từ ô hiện tại
                string imagePath = gridView1.GetRowCellValue(e.RowHandle, e.Column).ToString();


                // Kiểm tra nếu file tồn tại
                if (File.Exists(imagePath))
                {
                    // Chuyển đường dẫn thành hình ảnh
                    Image img = Image.FromFile(imagePath);

                    // Vẽ hình ảnh vào ô
                    e.Graphics.DrawImage(img, e.Bounds);
                    e.Handled = true; // Ngăn không vẽ dữ liệu mặc định lên ô
                }
            }
        }
    }
}
