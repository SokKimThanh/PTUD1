using BUS.Danh_Muc;
using BUS.Sys;
using DevExpress.XtraBars.Navigation;
using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
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
                objFunctionC1.Text = LanguageController.GetLanguageDataLabel(objFunctionC1.Text);
                objFunctionC1.Hint = LanguageController.GetLanguageDataLabel(objFunctionC1.Hint);
                //Kiểm tra xem có tồn tại chức năng con không
                if (objFunctionC1.Elements.Count == 0)
                    continue;

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
            arrFunction.Elements.AddRange(new AccordionControlElement[] {
                this.aceDatVe,
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});

            if (this.aceDanhMuc.Elements.FirstOrDefault(it => it.Name == "accQLNhanVien") == null)
                this.aceDanhMuc.Elements.Add(this.accQLNhanVien);
        }

        private void FunctionManager()
        {
            arrFunction.Elements.AddRange(new AccordionControlElement[] {
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

            arrFunction.Elements.AddRange(new AccordionControlElement[] {
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

        private void mainContainer_Click(object sender, EventArgs e)
        {

        }


        private void TimeExcute()
        {
            while (true)
            {
                string currentTime = DateTime.Now.ToString(CConfig.Time_Format_String);
                int v_iTime_Excute = 0;
                // Sử dụng Form hoặc Control cha để gọi BeginInvoke
                this.BeginInvoke(new Action(() =>
                {
                    lblTime.Caption = currentTime;
                    v_iTime_Excute = Auto_Delete_Tiket();
                }));

                Thread.Sleep(v_iTime_Excute); // Thêm delay để tránh vòng lặp quá nhanh
            }
        }

        private int Auto_Delete_Tiket()
        {
            DateTime v_dtmStart = DateTime.Now;
            try
            {
                tbl_DM_Bill_BUS v_objBill_Bus = new tbl_DM_Bill_BUS();
                tbl_DM_BillDetail_BUS v_objBill_Detail_BUS = new tbl_DM_BillDetail_BUS();
                tbl_DM_Ticket_BUS v_objTiket_BUS = new tbl_DM_Ticket_BUS();
                tbl_DM_Product_BUS v_objProduct_BUS = new tbl_DM_Product_BUS();
                tbl_DM_MovieSchedule_BUS v_objMovieSchedule_Bus = new tbl_DM_MovieSchedule_BUS();
                tbl_DM_Movie_BUS v_objMovie_Bus = new tbl_DM_Movie_BUS();

                foreach (tbl_DM_Bill_DTO v_objData in v_objBill_Bus.List_Data())
                {
                    // Lấy tiền của hóa đơn
                    double v_dblPrice = v_objData.BL_Total_Price;

                    //Tính tiền cần thanh toán dựa trên ghế và sản phẩm
                    v_objData.Bill_Detail = v_objBill_Detail_BUS.List_Data_By_Bill_ID(v_objData.BL_AutoID);
                    v_objData.Tiket = v_objTiket_BUS.List_Data_By_Bill_ID(v_objData.BL_AutoID);


                    double v_dblTong_Tien_SP = 0;
                    foreach (tbl_DM_BillDetail_DTO v_objBillDetail in v_objData.Bill_Detail)
                    {
                        tbl_DM_Product_DTO v_objSP = v_objProduct_BUS.Find(v_objBillDetail.BD_PRODUCT_AutoID);
                        if (v_objSP != null)
                        {
                            v_dblTong_Tien_SP += v_objSP.PD_PRICE * v_objBillDetail.BD_QUANTITY;
                        }
                    }

                    double v_dblTong_Tien_Ve = 0;

                    tbl_DM_Ticket_DTO v_objTiket = v_objData.Tiket.FirstOrDefault(it => it.BillID == v_objData.BL_AutoID);

                    //Lấy suất chiếu
                    tbl_DM_MovieSchedule_DTO v_objMovieSchedule = v_objMovieSchedule_Bus.GetLastMovieSchedule_ByID(v_objTiket.MovieScheID);
                    if (v_objMovieSchedule_Bus != null)
                    {
                        if ((DateTime.Now - v_objMovieSchedule.EndDate).TotalMilliseconds < 0)
                        {
                            continue;
                        }
                        //Lấy phim
                        tbl_DM_Movie_DTO v_objMovie = v_objMovie_Bus.Find(v_objMovieSchedule.Movie_AutoID);

                        if (v_objMovie != null)
                        {
                            v_dblTong_Tien_Ve = v_objData.Tiket.Count * v_objMovie.MV_PRICE;
                        }
                    }

                    //Tính dựa trên thực tế
                    if (v_dblTong_Tien_Ve + v_dblTong_Tien_SP > v_objData.BL_Total_Price)
                    {
                        //Tiến hành xóa theo hóa đơn
                        v_objBill_Bus.RemoveData(v_objData.BL_AutoID, CCommon.MaDangNhap, "Auto_Delete");
                        v_objBill_Detail_BUS.RemoveData(v_objData.BL_AutoID, CCommon.MaDangNhap, "Auto_Delete");
                        v_objTiket_BUS.RemoveData_By_Bill_ID(v_objData.BL_AutoID, CCommon.MaDangNhap, "Auto_Delete");
                    }
                }

            }
            catch (Exception)
            {

            }

            return (DateTime.Now - v_dtmStart).Milliseconds;
        }
    }
}
