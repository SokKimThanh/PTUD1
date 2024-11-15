using BUS.Danh_Muc;
using DTO.Common;
using DTO.tbl_DTO;
using System;
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

        public ucSanPham()
        {
            InitializeComponent();
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
            //productBUS.PD_QUANTITY = double.Parse(txtSoLuong.ToString().Trim());
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
                if (data.Add(product) != 0)
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
                txtUrlHinhAnh = selectedMV_POSTERURL;
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
                txtUrlHinhAnh = selectedMV_POSTERURL;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Kiểm tra nếu cột hiện tại là cột chứa đường dẫn hình ảnh
            if (e.Column.FieldName == "PD_IMAGEURL")
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
                else
                {
                    // Chuyển đường dẫn thành hình ảnh
                    Image img = Properties.Resources.gridview_no_image;
                    // Vẽ hình ảnh vào ô
                    e.Graphics.DrawImage(img, e.Bounds);
                    e.Handled = true; // Ngăn không vẽ dữ liệu mặc định lên ô
                }
            }
        }
    }
}
