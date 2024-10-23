using BUS.Danh_Muc;
using DTO.tbl_DTO;
using System;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucDanhGiaDoTuoi : ucBase
    {
        private readonly tbl_DM_AgeRating_BUS data = new tbl_DM_AgeRating_BUS();
        private string dgv_selected_id = "";

        public ucDanhGiaDoTuoi()
        {
            InitializeComponent();
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;
        }

        private tbl_DM_AgeRating_DTO GetFormData() =>
            new tbl_DM_AgeRating_DTO(long.Parse(dgv_selected_id), txtName.Text, txtNote.Text);

        protected override void Load_Data()
        {
            if (!string.IsNullOrEmpty(strFunctionCode))
                lblTitle.Text = strFunctionCode.ToUpper().Trim();

            dgv.DataSource = data.GetAll();
            dgv.RefreshDataSource();
            dangThaoTac(false);

            // Đặt tên tiếng Việt cho các cột
            gridView1.Columns["AR_NAME"].Caption = "Nhãn Đánh giá độ tuổi";
            gridView1.Columns["AR_NOTE"].Caption = "Mô tả";
            gridView1.Columns["AR_AutoID"].Visible = false;
        }

        // Thêm mới AgeRating
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var ageRating = new tbl_DM_AgeRating_DTO
                {
                    AR_NAME = txtName.Text,
                    AR_NOTE = txtNote.Text
                };
                data.Add(ageRating);
                MessageBox.Show("Thêm mới thành công!", "Thông báo");
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        // Xóa AgeRating
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

        // Cập nhật AgeRating
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
        // Làm mới dữ liệu
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }
        // Chọn dòng để cập nhật
        private void dgv_Click(object sender, EventArgs e)
        {
            int[] dong = gridView1.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        dgv_selected_id = gridView1.GetRowCellValue(i, "AR_AutoID").ToString().Trim();
                        tbl_DM_AgeRating_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtName.Text = o.AR_NAME;
                        txtNote.Text = o.AR_NOTE;
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
            txtName.Text = txtNote.Text = string.Empty;
        }
    }
}
