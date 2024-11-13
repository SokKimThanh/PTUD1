using BUS.Danh_Muc;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using GUI.UI.Component;

namespace GUI.UI.Modules
{
    public partial class ucChiPhi : ucBase
    {
        private readonly tbl_DM_ExpenseType_BUS expenseTypeBUS = new tbl_DM_ExpenseType_BUS();
        private readonly tbl_SYS_Expense_BUS data = new tbl_SYS_Expense_BUS();
        private readonly tbl_DM_Product_BUS productBUS = new tbl_DM_Product_BUS();

        tbl_DM_Product_DTO tbl_DM_Product_DTO = new tbl_DM_Product_DTO();

        private string dgv_selected_id = "";
        private long cboExpenseType_selected_id = 0;// giá trị từ ComboBoxEdit
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
            string price = txtPrice.Text.Replace("₫", "").Trim().Replace(".", "");
            entity.EX_PRICE = long.Parse(price);
            entity.EX_REASON = txtReason.Text.Trim();
            entity.EX_STATUS = int.Parse(cboExpenseStatus.EditValue.ToString());
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
            cboExpenseStatus.EditValue = null;
            cboExpenseType.EditValue = null;
        }

        private void ucChiPhi_Load(object sender, EventArgs e)
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();


            // Thêm các mục vào ComboBoxEdit thông qua Properties.Items
            cboExpenseType.Properties.DataSource = expenseTypeBUS.GetAll();
            cboExpenseType.Properties.DisplayMember = "ET_NAME";
            cboExpenseType.Properties.ValueMember = "ET_AutoID";
            cboExpenseType.ItemIndex = -1;
            cboExpenseType.Properties.Columns.Add(new LookUpColumnInfo("ET_NAME", "Tên loại chi phí", 100)); // Cột Tên loại chi phí

            // tạo trạng thái
            // Tạo một danh sách dữ liệu
            List<ExpenseStatus> dataSourceExpenseStatus = new List<ExpenseStatus>();
            dataSourceExpenseStatus.Add(new ExpenseStatus(0, "Hủy"));
            dataSourceExpenseStatus.Add(new ExpenseStatus(1, "Nhập"));

            cboExpenseStatus.Properties.DataSource = dataSourceExpenseStatus;
            cboExpenseStatus.Properties.DisplayMember = "EX_STATUS_NAME";
            cboExpenseStatus.Properties.ValueMember = "EX_STATUS_ID";
            cboExpenseStatus.ItemIndex = -1;
            cboExpenseStatus.Properties.Columns.Add(new LookUpColumnInfo("EX_STATUS_NAME", "Trạng thái", 100)); // Cột Trạng thái


            // tai du lieu dgv
            dgv.DataSource = data.GetAll();
            dgv.RefreshDataSource();
            dangThaoTac(false);

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gridView1.OptionsBehavior.Editable = false;

            // Đặt tên tiếng Việt cho các cột
            gridView1.Columns["EX_REASON"].Caption = "Lý do";
            gridView1.Columns["EX_QUANTITY"].Caption = "Số lượng";
            gridView1.Columns["EX_PRICE"].Caption = "Số tiền";
            gridView1.Columns["EX_STATUS"].Caption = "Trạng thái";
            gridView1.Columns["CREATED"].Caption = "Ngày nhập hàng";

            gridView1.Columns["EX_AutoID"].Visible = false;
            gridView1.Columns["EX_EXTYPE_AutoID"].Visible = false;
            gridView1.Columns["CREATED_BY"].Visible = false;
            gridView1.Columns["DELETED"].Visible = false;
            gridView1.Columns["CREATED_BY_FUNCTION"].Visible = false;
            gridView1.Columns["UPDATED"].Visible = false;
            gridView1.Columns["UPDATED_BY"].Visible = false;
            gridView1.Columns["UPDATED_BY_FUNCTION"].Visible = false;
            // Đặt VisibleIndex của cột về 0 để chuyển nó lên vị trí đầu tiên
            gridView1.Columns["EX_REASON"].VisibleIndex = 0;

            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
        }

        private void cboExpenseType_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboExpenseType.EditValue != null)
            {
                cboExpenseType_selected_id = long.Parse(cboExpenseType.EditValue.ToString().Trim());
                txtReason.Text = cboExpenseType.Text;
                cboExpenseStatus.EditValue = 1;
                tbl_DM_ExpenseType_DTO o = expenseTypeBUS.Find(cboExpenseType_selected_id);

                tbl_DM_Product_DTO = productBUS.Find((long)o.ET_PRODUCT_AutoID);

                // hiển thị nhập số lượng khi có id product
                txtQuantity.Enabled = true;
                txtPrice.Enabled = true;
            }
        }

        private void cboStatus_EditValueChanged(object sender, EventArgs e)
        {
            // lay id
            if (cboExpenseStatus.EditValue != null)
            {
                cboStatus_selected_id = long.Parse(cboExpenseStatus.EditValue.ToString().Trim());
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
                        dgv_selected_id = gridView1.GetRowCellValue(i, "EX_AutoID").ToString().Trim();
                        tbl_SYS_Expense_DTO o = data.Find(long.Parse(dgv_selected_id));
                        txtReason.Text = o.EX_REASON;
                        txtQuantity.Text = o.EX_QUANTITY.ToString();
                        txtPrice.Text = o.EX_PRICE.ToString();

                        // Hiển thị dữ liệu lên combobox
                        cboExpenseType.EditValue = o.EX_EXTYPE_AutoID;
                        cboExpenseStatus.EditValue = o.EX_STATUS;
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
