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

namespace GUI
{
    public partial class frmNhap_SL : DevExpress.XtraEditors.XtraForm
    {

        public bool Status_Close = false;

        public frmNhap_SL()
        {
            InitializeComponent();

            txtSan_Pham.Enabled = false;
            txtSo_Luong.Focus();
        }

        public void Set_Data(string p_strSan_Pham, double p_dblSo_Luong = 1)
        {
            txtSan_Pham.Text = p_strSan_Pham.Trim();
            txtSo_Luong.Text = p_dblSo_Luong.ToString();
        }

        public double Get_SL()
        {
            return Convert.ToDouble(txtSo_Luong.Text);
        }

        private void btnXac_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtSo_Luong.Text) <= 0)
                    throw new Exception("Vui lòng nhập số lượng > 0");
                Status_Close = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Status_Close = true;
            this.Close();
        }
    }
}