﻿using BUS.Danh_Muc;
using DevExpress.XtraEditors.Controls;
using DTO.tbl_DTO;
using GUI.UI.Component;
using System;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucChiPhiLoai : ucBase
    {
        private readonly tbl_DM_ExpenseType_BUS data = new tbl_DM_ExpenseType_BUS();
        private readonly tbl_DM_Product_BUS product_BUS = new tbl_DM_Product_BUS();


        private string dgv_selected_id = "";// giá trị từ gridcontrol
        private long cboProduct_selected_id = 0;// giá trị từ ComboBoxEdit

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();
        public ucChiPhiLoai()
        {
            InitializeComponent();
            lblTitle.Text = "LOẠI CHI PHÍ";

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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbl_DM_ExpenseType_DTO expense = GetFormData();

                if (data.Add(expense) != 0)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    LoadForm();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_ET_NAME"))
                {
                    MessageBox.Show($"Lỗi: Loại chi phí đã tồn tại", "Thông báo");
                }
                else
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
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
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
            Load_Data();
        }

        private void ucChiPhiLoai_Load(object sender, EventArgs e)
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();


            // Thêm các mục vào ComboBoxEdit thông qua Properties.Items
            cboSanPham.Properties.DataSource = product_BUS.GetAll(0);
            cboSanPham.Properties.DisplayMember = "PD_NAME";
            cboSanPham.Properties.ValueMember = "PD_AutoID";
            cboSanPham.ItemIndex = -1;
            cboSanPham.Properties.Columns.Add(new LookUpColumnInfo("PD_NAME", "Tên Sản phẩm", 100)); // Cột Tên loại chi phí

            // tai du lieu dgv
            dgv.DataSource = data.GetAll();
            dgv.RefreshDataSource();
            dangThaoTac(false);

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;

            // Đặt tên tiếng Việt cho các cột
            gridView1.Columns["ET_NAME"].Caption = "Tên loại chi phí";

            // Ẩn các cột không cần thiết
            gridView1.Columns["ET_AutoID"].Visible = false;
            gridView1.Columns["ET_PRODUCT_AutoID"].Visible = false;
            gridView1.Columns["CREATED"].Visible = false;
            gridView1.Columns["CREATED_BY"].Visible = false;
            gridView1.Columns["DELETED"].Visible = false;
            gridView1.Columns["CREATED_BY_FUNCTION"].Visible = false;
            gridView1.Columns["UPDATED"].Visible = false;
            gridView1.Columns["UPDATED_BY"].Visible = false;
            gridView1.Columns["UPDATED_BY_FUNCTION"].Visible = false;
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
                        dgv_selected_id = gridView1.GetRowCellValue(i, "ET_AutoID").ToString().Trim();
                        tbl_DM_ExpenseType_DTO o = data.Find(long.Parse(dgv_selected_id));

                        // Hiển thị dữ liệu lên EditText
                        txtExpenseTypeName.Text = o.ET_NAME;

                        // Hiển thị dữ liệu lên Combobox
                        cboSanPham.EditValue = o.ET_PRODUCT_AutoID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }

        private void cboSanPham_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboSanPham.EditValue != null)
            {
                cboProduct_selected_id = long.Parse(cboSanPham.EditValue.ToString().Trim());
                txtExpenseTypeName.Text = "Nhập: " + product_BUS.Find(cboProduct_selected_id).PD_NAME;
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
            txtExpenseTypeName.Text = string.Empty;
            cboSanPham.EditValue = null;
        }
        private tbl_DM_ExpenseType_DTO GetFormData()
        {
            // Sử dụng constructor của tbl_DM_Movie_DTO để tạo đối tượng entity
            var entity = new tbl_DM_ExpenseType_DTO();
            entity.ET_NAME = txtExpenseTypeName.Text.Trim();// lý do nhập hàng 
            try
            {
                if (cboSanPham.EditValue != null)
                {
                    entity.ET_PRODUCT_AutoID = int.Parse(cboSanPham.EditValue.ToString());// sản phẩm
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Lỗi");
            }
            //  selected id on datagridview
            if (dgv_selected_id != "")
            {
                entity.ET_AutoID = long.Parse(dgv_selected_id);// mã chi phí 
            }
            return entity;
        }
    }
}
