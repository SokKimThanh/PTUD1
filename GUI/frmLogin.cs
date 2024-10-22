using BUS.Danh_Muc;
using DTO.Custom;
using DTO.Utility;
using System;
using System.IO;
using System.Text;
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

                //B1. Kiểm tra xem file chứa thông tin đăng nhập có tồn tại trên máy không nếu không thì tạo mới
                if (Directory.Exists(CConfig.CM_Cinema_FileManagement_Folder) == false)
                    Directory.CreateDirectory(CConfig.CM_Cinema_FileManagement_Folder);

                string strFileName = "userinfo.txt";
                string strFullFilePath = CConfig.CM_Cinema_FileManagement_Folder + strFileName;

                //Tạo file nếu file không tồn tại
                if (File.Exists(strFullFilePath) == false)
                {
                    using (FileStream objFile = File.Create(strFullFilePath))
                    {

                    }
                }

                //Ghi các thông tin đã đc mã hóa vào file
                using (Stream objStream = File.Open(strFullFilePath, FileMode.Open))
                {
                    using (StreamWriter objSW = new StreamWriter(objStream, Encoding.UTF8))
                    {
                        string strMaDangNhap_MD5 = CUtility.MD5_Encrypt(txtTenDangNhap.Text);
                        string strMatKhau_MD5 = CUtility.MD5_Encrypt(txtMatKhau.Text);

                        // Ghi từng dòng
                        objSW.WriteLine(strMaDangNhap_MD5);
                        objSW.WriteLine(strMatKhau_MD5);
                    }
                }

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
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    StatusClose = true;

                    // Thoát chương trình
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnDangNhap_Click(sender, e);
                    e.Handled = true; // Ngăn chặn sự kiện tiếp tục
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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