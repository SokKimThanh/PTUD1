using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.Navigation;
using DTO.Common;
using DTO.Custom;
using GUI.UI.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        /// <summary>
        /// Nơi khai báo mã chức năng và user control
        /// </summary>
        private Dictionary<string, ucBase> dicFunction = new Dictionary<string, ucBase>()
        {
            { "accCaiDat", new ucCaiDat() },
            { "accDatVe", new ucChonPhim() },
            { "accVe", new ucVe() },
            { "accQLHoaDon", new ucHoaDon() },
            { "accQLPhim", new ucPhim() },
            { "accQLSanPham", new ucSanPham() },
            { "accQLPhongChieu", new ucPhongChieu() },
            { "accQLSuatChieu", new ucSuatChieu() },
            { "accQLNhanVien", new ucNhanVien() },
            { "accQLPhanCa", new ucPhanCa() },
            { "accQLCaLamViec", new ucCaLamViec() },
            { "accQLDanhGiaDoTuoi", new ucDanhGiaDoTuoi() },
            { "accBaoCaoDoanhThu", new ucBaoCaoDoanhThu() },
            { "accBaoCaoThuChi", new ucBaoCaoThuChi() },
            { "accBaoCaoTonKho", new ucBaoCaoTonKho() },
            { "accChiPhi", new ucChiPhi() },
            { "accLoaiChiPhi", new ucChiPhiLoai() },
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
            accordionControl.Elements.Clear();
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
            foreach (AccordionControlElement objFunctionC1 in accordionControl.Elements)
            {
                objFunctionC1.Text = LanguageController.GetLanguageDataLabel(objFunctionC1.Text);
                objFunctionC1.Hint = LanguageController.GetLanguageDataLabel(objFunctionC1.Hint);

                foreach (AccordionControlElement objFunctionC2 in objFunctionC1.Elements)
                {
                    objFunctionC2.Text = LanguageController.GetLanguageDataLabel(objFunctionC2.Text);
                    objFunctionC2.Hint = LanguageController.GetLanguageDataLabel(objFunctionC2.Hint);

                    //Gán sự kiện click cho từng chức năng con
                    objFunctionC2.Click += LoadFunction_Click;
                }
            }
        }

        private void FunctionADMIN()
        {
            accordionControl.Elements.AddRange(new AccordionControlElement[] {
                this.aceDatVe,
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});

            if (this.aceDanhMuc.Elements.FirstOrDefault(it => it.Name == "accQLNhanVien") == null)
                this.aceDanhMuc.Elements.Add(this.accQLNhanVien);
        }

        private void FunctionManager()
        {
            accordionControl.Elements.AddRange(new AccordionControlElement[] {
                 this.aceDatVe,
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});

            if (this.aceDanhMuc.Elements.FirstOrDefault(it => it.Name == "accQLNhanVien") == null)
                this.aceDanhMuc.Elements.Add(this.accQLNhanVien);
        }

        private void FunctionStaff()
        {
            //Nhân viên thì k vào được chức năng báo cáo
            this.aceDanhMuc.Elements.Remove(this.accQLNhanVien);

            accordionControl.Elements.AddRange(new AccordionControlElement[] {
            this.aceDatVe,
            this.aceDanhMuc,
            this.aceHeThong});


        }

        #endregion

        #region Event
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            tbl_DM_Staff_BUS objStaffController = new tbl_DM_Staff_BUS();
            try
            {
                //Kiểm tra dưới file
                if (CCommon.MaDangNhap == "")
                {
                    try
                    {
                        //Kiểm tra trong file
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

                        //Đọc thông tin file
                        using (Stream objStream = File.Open(strFullFilePath, FileMode.Open))
                        {
                            using (StreamReader objSR = new StreamReader(objStream, Encoding.UTF8))
                            {
                                string strMaDangNhap = objSR.ReadLine();
                                string strMatKhau = objSR.ReadLine();

                                //Kiểm tra xem thông tin lưu trong file còn khớp hay khôn
                                //Kiểm tra các trường đọc lên có dữ liệu hay không
                                if (string.IsNullOrEmpty(strMaDangNhap) == false && string.IsNullOrEmpty(strMatKhau) == false)
                                {
                                    //Nếu có check xem thông tin có còn khớp dưới db
                                    CCommon.MaDangNhap = objStaffController.CheckLoginFileProcess(strMaDangNhap, strMatKhau);
                                }

                            }
                        }

                    }
                    catch (Exception)
                    {

                    }
                }

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

                mainContainer.Controls.Clear();

                Task.Run(() => TimeExcute());
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ucBase objLoad = dicFunction[objElement.Name];
                    if (objLoad == null)
                        return;

                    objLoad.strFunctionCode = objElement.Text;

                    // Nếu UserControl đã có trong mainContainer thì đưa nó lên trước
                    if (mainContainer.Controls.Contains(objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        mainContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        mainContainer.Controls.Add(objLoad);
                        objLoad.Load_DataBase(objSender, e);
                    }

                    // Đưa nó lên phía trước
                    objLoad.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (DialogResult.Yes == MessageBox.Show(LanguageController.GetLanguageDataLabel("Bạn có muốn đăng xuất?"), LanguageController.GetLanguageDataLabel("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Kiểm tra dưới file
                    if (CCommon.MaDangNhap != "")
                    {
                        try
                        {
                            //Kiểm tra trong file
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

                            //Xóa dữ liệu của file đi
                            using (FileStream fs = new FileStream(strFullFilePath, FileMode.Truncate))
                            {
                                // File sẽ bị xóa hết dữ liệu nhưng file vẫn tồn tại
                                // Không cần ghi gì, chỉ mở file với chế độ Truncate
                            }

                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }

                    //Gán lại biến common
                    CCommon.MaDangNhap = "";

                    //gọi lại sự kiện load
                    this.OnLoad(EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void accThoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(LanguageController.GetLanguageDataLabel("Bạn có muốn thoát chương trình?"), LanguageController.GetLanguageDataLabel("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // Thoát chương trình
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int SC_SIZE = 0xF000; // Mã lệnh cho thay đổi kích thước
                                        // Các mã lệnh khác có thể liên quan

            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE || command == SC_SIZE)
                        return; // Chặn cả di chuyển và thay đổi kích thước
                    break;


                case WM_NCLBUTTONDBLCLK:
                    message.Result = IntPtr.Zero;
                    return;
            }

            base.WndProc(ref message);
        }


        private void TimeExcute()
        {
            while (true)
            {
                try
                {
                    string currentTime = DateTime.Now.ToString(CConfig.Time_Format_String);

                    // Sử dụng Form hoặc Control cha để gọi BeginInvoke
                    this.BeginInvoke(new Action(() =>
                    {
                        lblTime.Caption = currentTime;
                    }));

                    Thread.Sleep(1000); // Thêm delay để tránh vòng lặp quá nhanh
                }
                catch (Exception)
                {

                }
            }
        }

        private void arrFunction_ElementClick(object sender, ElementClickEventArgs e)
        {
            accordionControl.FindForm().Activate();
        }
    }
}
