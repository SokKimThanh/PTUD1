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

        tbl_DM_Product_DTO product_DTO = new tbl_DM_Product_DTO();

        private string dgv_selected_id = "";// giá trị từ gridcontrol
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
                tbl_SYS_Expense_DTO expense = GetFormData();

                if (data.Add(expense) != 0)
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
            entity.EX_PRICE = long.Parse(price);// tiền nhập hàng
            entity.EX_REASON = txtReason.Text.Trim();// lý do nhập hàng
            entity.EX_STATUS = int.Parse(cboExpenseStatus.EditValue.ToString());// trạng thái nhập hàng
            entity.EX_QUANTITY = double.Parse(txtQuantity.Text.Trim());// số lượng sản phẩm nhập hàng
            entity.EX_EXTYPE_AutoID = int.Parse(cboExpenseType.EditValue.ToString());// loại chi phí
            //  selected id on datagridview
            if (dgv_selected_id != "")
            {
                entity.EX_AutoID = long.Parse(dgv_selected_id);// mã chi phí 
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
            txtProductQuantity.Text = string.Empty;
            txtProductName.Text = string.Empty;
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
            try
            {
                // lay id
                if (cboExpenseType.EditValue != null)
                {
                    cboExpenseType_selected_id = long.Parse(cboExpenseType.EditValue.ToString().Trim());
                    txtReason.Text = cboExpenseType.Text;
                    cboExpenseStatus.EditValue = 1;
                    try
                    {
                        //  Bước chuẩn bị: Tìm sản phẩm để cập nhật số lượng
                        //  khi thêm số lượng sản phẩm cho loại chi phí
                        //  theo số lần thêm hàng (thêm 1 dòng chi phí)
                        if (cboExpenseType_selected_id != 0)
                        {
                            tbl_DM_ExpenseType_DTO o = expenseTypeBUS.Find(cboExpenseType_selected_id);
                            product_DTO = productBUS.Find((long)o.ET_PRODUCT_AutoID);
                            if (product_DTO != null)
                            {
                                // Hiển thị số lượng tồn kho cho loại chi phí nhập
                                txtProductQuantity.Text = data.GetQuantityProduct(cboExpenseType_selected_id).ToString();

                                // Hiển thị tên sản phẩm
                                txtProductName.Text = product_DTO.PD_NAME;
                            }
                        }
                    }
                    catch 
                    {
                        MessageBox.Show($"Vui lòng thêm loại chi phí tương ứng với sản phẩm.", "Thông báo");
                    }
                    
                    // hiển thị nhập số lượng khi có id product
                    txtQuantity.Enabled = true;
                    txtPrice.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
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
