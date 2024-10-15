using DevExpress.XtraBars;
using GUI.UI.Modules;
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
    public partial class frmMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl control)
        {
            // Xóa tất cả các control hiện tại trong main container
            //mainContainer.Controls.Clear();

            // Dock control vào container để nó chiếm toàn bộ diện tích
            control.Dock = DockStyle.Fill;

            // Thêm UserControl vào main container
            mainContainer.Controls.Add(control);

            // Đưa nó lên phía trước (nếu đã có)
            control.BringToFront();
        }
        private void accDatVe_Click(object sender, EventArgs e)
        {
            LoadControl(new ucDatVe());
        }

        private void accQLHoaDon_Click(object sender, EventArgs e)
        {
            LoadControl(new ucHoaDon());
        }

        private void accInHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            LoadControl(new ucInHoaDon());
        }

        private void accQLPhim_Click(object sender, EventArgs e)
        {
            LoadControl(new ucPhim());
        }

        private void accQLSanPham_Click(object sender, EventArgs e)
        {
            LoadControl(new ucSanPham());
        }

        private void accQLPhongChieu_Click(object sender, EventArgs e)
        {
            LoadControl(new ucPhongChieu());
        }

        private void accQLSuatChieu_Click(object sender, EventArgs e)
        {
            LoadControl(new ucSuatChieu());
        }

        private void accQLNhanVien_Click(object sender, EventArgs e)
        {
            LoadControl(new ucNhanVien());
        }

        private void accQLPhanCa_Click(object sender, EventArgs e)
        {
            LoadControl(new ucPhanCa());
        }

        private void accQLCaLamViec_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCaLamViec());
        }

        private void accQLGhe_Click(object sender, EventArgs e)
        {
            LoadControl(new ucGhe());
        }

        private void accQLDanhGiaDoTuoi_Click(object sender, EventArgs e)
        {
            LoadControl(new ucDanhGiaDoTuoi());
        }

        private void accBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            LoadControl(new ucBaoCaoDoanhThu());
        }

        private void accBaoCaoThuChi_Click(object sender, EventArgs e)
        {
            LoadControl(new ucBaoCaoThuChi());
        }

        private void accBaoCaoTonKho_Click(object sender, EventArgs e)
        {
            LoadControl(new ucBaoCaoTonKho());
        }

        private void accDangXuat_Click(object sender, EventArgs e)
        {
            // Ẩn form chính
            this.Hide();

            // Mở lại form đăng nhập
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            // Sau khi form đăng nhập đóng, thoát form chính
            this.Close();
        }

        private void accThoatVaDangXuat_Click(object sender, EventArgs e)
        {
            // thoat chuong trinh & giai phong bo nho
            Application.Exit();
        }
    }
}
