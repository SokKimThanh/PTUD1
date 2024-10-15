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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập
            bool loginSuccessful = true;

            if (txtTenDangNhap.Text != "admin" && txtMatKhau.Text != "1")
            {
                loginSuccessful = false;
            }

            if (loginSuccessful)
            {
                // Ẩn form đăng nhập
                this.Hide();

                // Mở form chính
                frmMainForm mainForm = new frmMainForm();
                mainForm.ShowDialog();

                // Khi form chính đóng lại (sau khi người dùng nhấn Logout)
                this.Show(); // Mở lại form đăng nhập
            }
            else
            {
                // Hiển thị thông báo nếu đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin.");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}