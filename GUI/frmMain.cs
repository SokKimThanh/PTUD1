using BUS.Danh_Muc;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DTO.Common;
using DTO.Custom;
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
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        /// <summary>
        /// Nơi khai báo mã chức năng và user control
        /// </summary>
        private Dictionary<string, UserControl> dicFunction = new Dictionary<string, UserControl>()
        {
            { "accDatVe", new ucDatVe() },
            { "accQLHoaDon", new ucHoaDon() },
            { "accQLPhim", new ucPhim() },
            { "accQLSanPham", new ucSanPham() },
            { "accQLPhongChieu", new ucPhongChieu() },
            { "accQLSuatChieu", new ucSuatChieu() },
            { "accQLNhanVien", new ucNhanVien() },
            { "accQLPhanCa", new ucPhanCa() },
            { "accQLCaLamViec", new ucCaLamViec() },
            { "accQLGhe", new ucGhe() },
            { "accQLDanhGiaDoTuoi", new ucDanhGiaDoTuoi() },
            { "accBaoCaoDoanhThu", new ucBaoCaoDoanhThu() },
            { "accBaoCaoThuChi", new ucBaoCaoThuChi() },
            { "accBaoCaoTonKho", new ucBaoCaoTonKho() },
        };

        private frmLoading frmLoad = null;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Function bổ trợ

        private void LoadFunctionByLevel(int iLevel)
        {
            //Xóa hết chức năng trên menu đi
            arrFunction.Elements.Clear();
            switch (iLevel)
            {
                case (int)ELevel.Admin:
                    FunctionADMIN();
                    break;

                case (int)ELevel.Manager:
                    FunctionManager();
                    break;

                case (int)ELevel.Staff:
                    FunctionStaff();
                    break;
            }

            //Duyệt qua cây chức năng sau khi đã load
            foreach (AccordionControlElement objFunctionC1 in arrFunction.Elements)
            {
                //Kiểm tra xem có tồn tại chức năng con không
                if (objFunctionC1.Elements.Count == 0)
                    continue;

                foreach (AccordionControlElement objFunctionC2 in objFunctionC1.Elements)
                {
                    //Gán sự kiện click cho từng chức năng con
                    objFunctionC2.Click += LoadFunction_Click;
                }
            }
        }

        private void FunctionADMIN()
        {
            arrFunction.Elements.AddRange(new AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
        }

        private void FunctionManager()
        {
            arrFunction.Elements.AddRange(new AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
        }

        private void FunctionStaff()
        {
            arrFunction.Elements.AddRange(new AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceHeThong});
        }

        #endregion

        #region Event
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            StaffController objStaffController = new StaffController();
            try
            {
                //Kiểm tra xem đã đăng nhập hay chưa
                if (CCommon.MaDangNhap == "")
                {
                    //Ẩn form hiện tại đi
                    this.Hide();

                    //Chưa chưa gọi form login
                    frmLogin objLoginForm = new frmLogin();
                    objLoginForm.ShowDialog();

                    //Xử lý toàn vẹn dữ liệu, sự kiện đầu ra trong login form
                    //Show lại form nếu người dùng k nhấn nút thoát bên form login
                    if (objLoginForm.StatusClose == true)
                        return;
                    this.Show();
                }

                frmLoad = new frmLoading();
                frmLoad.SetCaption("Hệ thống đang tải....");
                frmLoad.SetDescription("Vui lòng chờ một lát.");

                frmLoad.Show();

                //Dựa vào phân quyền để load cây chức năng theo
                int iLevel = objStaffController.LoadLevelByMaDangNhap(CCommon.MaDangNhap);
                LoadFunctionByLevel(iLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (frmLoad != null)
                {
                    frmLoad.Close();
                    frmLoad.Dispose();
                }
            }
        }

        private void LoadFunction_Click(object objSender, EventArgs e)
        {
            //Kiểm tra dữ liệu có null và có phải kiểu AccordionControlElement hay không
            if (objSender != null && objSender.GetType() == typeof(AccordionControlElement))
            {
                try
                {
                    frmLoad = new frmLoading();
                    frmLoad.SetCaption("Hệ thống đang tải....");
                    frmLoad.SetDescription("Vui lòng chờ một lát.");

                    frmLoad.Show();

                    AccordionControlElement objElement = objSender as AccordionControlElement;

                    // Kiểm tra xem nó có trong dicFunction hay không
                    if (dicFunction.ContainsKey(objElement.Name) == false)
                        return;

                    // Lấy UserControl tương ứng với tên
                    UserControl objLoad = dicFunction[objElement.Name];
                    if (objLoad == null)
                        return;

                    // Nếu UserControl đã có trong mainContainer thì đưa nó lên trước
                    if (mainContainer.Controls.Contains(objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        mainContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        mainContainer.Controls.Add(objLoad);
                    }

                    // Đưa nó lên phía trước
                    objLoad.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (frmLoad != null)
                    {
                        frmLoad.Close();
                        frmLoad.Dispose();
                    }
                }
            }
        }

        private void accDangXuat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Gán lại biến common
                CCommon.MaDangNhap = "";

                //gọi lại sự kiện load
                this.OnLoad(EventArgs.Empty);
            }
        }

        private void accThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // Thoát chương trình
                Application.Exit();
            }
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
