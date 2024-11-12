using BUS.Danh_Muc;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
using System.Xml.Linq;

namespace GUI.UI.Modules
{
    public partial class ucChiPhi : ucBase
    {
        private readonly tbl_DM_ExpenseType_BUS expenseType_BUS = new tbl_DM_ExpenseType_BUS();
        private readonly tbl_SYS_Expense_BUS data = new tbl_SYS_Expense_BUS();

        private string dgv_selected_id = "";
        private long? cboExpenseType_selected_id = 0;// giá trị từ ComboBoxEdit
        private long? cboStatus_selected_id = 0;// giá trị từ ComboBoxEdit

        public ucChiPhi()
        {
            InitializeComponent();
            lblTitle.Text = "CHI PHÍ";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbl_SYS_Expense_DTO movie = GetFormData();

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
        private tbl_SYS_Expense_DTO GetFormData()
        {
            // Sử dụng constructor của tbl_DM_Movie_DTO để tạo đối tượng entity
            var entity = new tbl_SYS_Expense_DTO();
            entity.EX_PRICE = long.Parse(txtPrice.Text.Trim());
            entity.EX_REASON = txtReason.Text.Trim();
            entity.EX_STATUS = int.Parse(cboStatus.EditValue.ToString());
            entity.EX_QUANTITY = double.Parse(txtQuantity.Text.Trim());
            entity.EX_EXTYPE_AutoID = int.Parse(cboExpenseType.EditValue.ToString());
            // edit selected id on datagridview
            if (dgv_selected_id != "")
            {
                entity.EX_AutoID = long.Parse(dgv_selected_id);
            }
            return entity;
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
            txtReason.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cboStatus.EditValue = null;
            cboExpenseType.EditValue = null;
        }

        private void ucChiPhi_Load(object sender, EventArgs e)
        {

        }

        private void cboExpenseType_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboExpenseType.EditValue != null)
            {
                cboExpenseType_selected_id = long.Parse(cboExpenseType.EditValue.ToString().Trim());
            }
        }

        private void cboStatus_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboStatus.EditValue != null)
            {
                cboStatus_selected_id = long.Parse(cboStatus.EditValue.ToString().Trim());
            }
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
                        tbl_SYS_Expense_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtReason.Text = o.EX_REASON;
                        txtQuantity.Text = o.EX_QUANTITY.ToString();
                        txtPrice.Text = o.EX_PRICE.ToString();

                        // Hiển thị dữ liệu lên combobox
                        cboExpenseType.EditValue = o.EX_EXTYPE_AutoID;
                        cboStatus.EditValue = o.EX_STATUS;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }
    }
}
