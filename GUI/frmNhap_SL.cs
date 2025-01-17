﻿using System;
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

        public void Set_Data(string p_strSan_Pham, int maxValue = 10, double p_dblSo_Luong = 1, string p_strTitle = "")
        {
            if (p_strTitle != "")
            {
                lblSan_Pham.Text = p_strTitle;
            }
            
            txtSan_Pham.Text = p_strSan_Pham.Trim();

            txtSo_Luong.Properties.MaxValue = maxValue;

            if (maxValue == 0)
                p_dblSo_Luong = 0;

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
                if (Convert.ToDouble(txtSo_Luong.Text) < 0)
                    throw new Exception("Vui lòng nhập số lượng >= 0");
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

        private void txtSo_Luong_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            if(!e.IsSpinUp)
            { 
                if (txtSo_Luong.Value - txtSo_Luong.Properties.Increment < txtSo_Luong.Properties.MinValue) 
                { 
                    e.Handled = true;
                    txtSo_Luong.Value = txtSo_Luong.Properties.MinValue; 
                }
            }
            else
            {
                if (txtSo_Luong.Value + txtSo_Luong.Properties.Increment > txtSo_Luong.Properties.MaxValue)
                {
                    e.Handled = true;
                    txtSo_Luong.Value = txtSo_Luong.Properties.MaxValue;
                }
            }
        }

        private void txtSo_Luong_EditValueChanged(object sender, EventArgs e)
        {
            if((decimal)txtSo_Luong.EditValue > txtSo_Luong.Properties.MaxValue)
            {
                txtSo_Luong.EditValue = txtSo_Luong.Properties.MaxValue;
            }
            else if ((decimal)txtSo_Luong.EditValue < txtSo_Luong.Properties.MinValue)
            {
                txtSo_Luong.EditValue = txtSo_Luong.Properties.MinValue;
            }
        }
    }
}