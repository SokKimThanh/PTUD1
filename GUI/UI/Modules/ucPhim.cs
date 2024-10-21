using BUS;
using BUS.Danh_Muc;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.UI.Modules
{
    public partial class ucPhim : ucBase
    {
        private tbl_DM_AgeRating_BUS cboAgeRatingData = new tbl_DM_AgeRating_BUS();
        private tbl_DM_Movie_BUS data = new tbl_DM_Movie_BUS();

        private string dgv_selected_id = "";
        private long cboAgeRating_selected_id = -1;
        public ucPhim()
        {
            InitializeComponent();
        }

        private tbl_DM_Movie_DTO GetFormData()
        {
            // Sử dụng constructor của tbl_DM_Movie_DTO để tạo đối tượng movie
            var movie = new tbl_DM_Movie_DTO(
                mV_NAME: txtName.Text,
                mV_POSTERURL: txtUrlHinhAnh.Text,
                mV_DESCRIPTION: txtDescription.Text,
                mV_PRICE: double.Parse(txtPrice.Text.Trim()),
                mV_DURATION: int.Parse(txtDurations.Text.Trim()),
                mV_AutoID: long.Parse(dgv_selected_id)
            //mV_AGERATING_AutoID: (long?)cboAgeRating.EditValue // giá trị từ ComboBoxEdit
            );

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
        }
        // Thêm mới movie
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                        dgv_selected_id = gridView1.GetRowCellValue(i, "MV_AUTOID").ToString().Trim();
                        tbl_DM_Movie_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtName.Text = o.MV_NAME;
                        txtDescription.Text = o.MV_DESCRIPTION;
                        txtDurations.Text = o.MV_DURATION.ToString();
                        txtUrlHinhAnh.Text = o.MV_POSTERURL;
                        txtPrice.Text = o.MV_PRICE.ToString();
                        cboAgeRating.ItemIndex = -1;
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
            cboAgeRating.ItemIndex = -1;
        }

        private void cboAgeRating_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            cboAgeRating_selected_id = long.Parse(cboAgeRating.EditValue.ToString().Trim());
            //tbl_DM_AgeRating_DTO o = cboAgeRatingData.Find(cboAgeRating_selected_id);
            MessageBox.Show(cboAgeRating_selected_id.ToString(), "show id");
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
                string selectedImagePath = openFileDialog.FileName;

                // Hiển thị đường dẫn hình ảnh trong TextBox hoặc Label
                txtUrlHinhAnh.Text = selectedImagePath;
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
                string selectedImagePath = openFileDialog.FileName;

                // Hiển thị đường dẫn hình ảnh trong TextBox hoặc Label
                txtUrlHinhAnh.Text = selectedImagePath;
            }
        }
    }
}
