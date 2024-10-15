using BUS.Danh_Muc;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public bool StatusClose { get; set; } = false; // không đóng form

        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true; // Cho phép form nhận sự kiện phím

            this.KeyDown += LoginForm_KeyDown;
        }

        #region Event

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                StaffController objController = new StaffController();
                objController.LoginProcess(txtTenDangNhap.Text, txtMatKhau.Text);

                //Nếu pass hết thì đóng form
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                StatusClose = true;

                // Thoát chương trình
                Application.Exit();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.Handled = true; // Ngăn chặn sự kiện tiếp tục
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int SC_SIZE = 0xF000; // Mã lệnh cho thay đổi kích thước

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE || command == SC_SIZE)
                        return; // Chặn cả di chuyển và thay đổi kích thước
                    break;
            }

            base.WndProc(ref message);
        }
    }
}