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
    public partial class frmThanh_Toan : DevExpress.XtraEditors.XtraForm
    {
        public bool Status_Close = false;
        private double m_dblPrice = 0;
        public frmThanh_Toan()
        {
            InitializeComponent();

            txtMa_HD.Enabled = false;
            txtGia.Enabled = false;
            btnHuy.Click += btnHuy_Click;
        }

        public void Set_Data(string p_strTitle, double p_dblTien)
        {
            m_dblPrice = p_dblTien;
            txtMa_HD.Text = p_strTitle;
            txtGia.Text = p_dblTien.ToString();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnXac_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtGia.Text) <= 0)
                    throw new Exception("Vui lòng nhập giá > 0");

                Status_Close = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double Get_Gia()
        {
            return m_dblPrice;
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int SC_SIZE = 0xF000; // Mã lệnh cho thay đổi kích thước
                                        // Các mã lệnh khác có thể liên quan
            const int WM_NCLBUTTONDOWN = 0x00A1; // Click chuột vào thanh tiêu đề
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE || command == SC_SIZE)
                        return; // Chặn cả di chuyển và thay đổi kích thước
                    break;

                case WM_NCLBUTTONDOWN:
                    // Chặn hành động nhấn chuột vào thanh tiêu đề
                    return;

                case WM_NCLBUTTONDBLCLK:
                    message.Result = IntPtr.Zero;      
                    return;
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