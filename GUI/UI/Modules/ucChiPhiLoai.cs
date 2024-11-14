using BUS.Danh_Muc;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucChiPhiLoai : ucBase
    {
        private readonly tbl_DM_ExpenseType_BUS data = new tbl_DM_ExpenseType_BUS();

        public ucChiPhiLoai()
        {
            InitializeComponent();
            lblTitle.Text = "LOẠI CHI PHÍ";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
            Load_Data();
        }

        private void ucChiPhiLoai_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void cboSanPham_EditValueChanged(object sender, EventArgs e)
        {

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
    }
}
