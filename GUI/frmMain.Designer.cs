namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.arrFunction = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDatVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhongChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSuatChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhanCa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLCaLamViec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLGhe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLDanhGiaDoTuoi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoThuChi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoTonKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accNgonNgu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.arrFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(700, 608);
            this.mainContainer.TabIndex = 0;
            // 
            // arrFunction
            // 
            this.arrFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.arrFunction.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
            this.arrFunction.Location = new System.Drawing.Point(0, 31);
            this.arrFunction.Name = "arrFunction";
            this.arrFunction.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.arrFunction.Size = new System.Drawing.Size(260, 608);
            this.arrFunction.TabIndex = 1;
            this.arrFunction.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceDanhMuc
            // 
            this.aceDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDatVe,
            this.accQLHoaDon,
            this.accQLPhim,
            this.accQLSanPham,
            this.accQLPhongChieu,
            this.accQLSuatChieu,
            this.accQLNhanVien,
            this.accQLPhanCa,
            this.accQLCaLamViec,
            this.accQLGhe,
            this.accQLDanhGiaDoTuoi});
            this.aceDanhMuc.Expanded = true;
            this.aceDanhMuc.ImageOptions.Image = global::GUI.Properties.Resources.add_32x32;
            this.aceDanhMuc.Name = "aceDanhMuc";
            this.aceDanhMuc.Text = "Danh Mục";
            // 
            // accDatVe
            // 
            this.accDatVe.ImageOptions.Image = global::GUI.Properties.Resources.iconsetredtoblack4_16x162;
            this.accDatVe.Name = "accDatVe";
            this.accDatVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDatVe.Text = "Đặt vé";
            this.accDatVe.Click += new System.EventHandler(this.accDatVe_Click);
            // 
            // accQLPhim
            // 
            this.accQLPhim.Hint = "Quản Lý Phim";
            this.accQLPhim.ImageOptions.Image = global::GUI.Properties.Resources.add_16x164;
            this.accQLPhim.Name = "accQLPhim";
            this.accQLPhim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhim.Text = "Phim";
            // 
            // accQLHoaDon
            // 
            this.accQLHoaDon.Hint = "Quản lý Hóa Đơn";
            this.accQLHoaDon.ImageOptions.Image = global::GUI.Properties.Resources.apply_16x16;
            this.accQLHoaDon.Name = "accQLHoaDon";
            this.accQLHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLHoaDon.Text = "Hóa Đơn";
            // 
            // accQLSanPham
            // 
            this.accQLSanPham.Hint = "Quản Lý Sản Phẩm";
            this.accQLSanPham.ImageOptions.Image = global::GUI.Properties.Resources.add_16x167;
            this.accQLSanPham.Name = "accQLSanPham";
            this.accQLSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLSanPham.Text = "Sản Phẩm";
            // 
            // accQLPhongChieu
            // 
            this.accQLPhongChieu.Hint = "Quản Lý Phòng Chiếu";
            this.accQLPhongChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x168;
            this.accQLPhongChieu.Name = "accQLPhongChieu";
            this.accQLPhongChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhongChieu.Text = "Phòng Chiếu";
            // 
            // accQLSuatChieu
            // 
            this.accQLSuatChieu.Hint = "Quản Lý Suất Chiếu";
            this.accQLSuatChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x169;
            this.accQLSuatChieu.Name = "accQLSuatChieu";
            this.accQLSuatChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLSuatChieu.Text = "Suất Chiếu";
            // 
            // accQLNhanVien
            // 
            this.accQLNhanVien.Hint = "Quản Lý Nhân Viên";
            this.accQLNhanVien.ImageOptions.Image = global::GUI.Properties.Resources.add_16x163;
            this.accQLNhanVien.Name = "accQLNhanVien";
            this.accQLNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLNhanVien.Text = "Nhân Viên";
            // 
            // accQLPhanCa
            // 
            this.accQLPhanCa.Hint = "Quản lý Phân Ca";
            this.accQLPhanCa.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLPhanCa.Name = "accQLPhanCa";
            this.accQLPhanCa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhanCa.Text = "Phân Ca";
            // 
            // accQLCaLamViec
            // 
            this.accQLCaLamViec.Hint = "Quản lý Ca Làm Việc";
            this.accQLCaLamViec.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLCaLamViec.Name = "accQLCaLamViec";
            this.accQLCaLamViec.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLCaLamViec.Text = "Ca Làm Việc";
            // 
            // accQLGhe
            // 
            this.accQLGhe.Hint = "Quản lý ghế";
            this.accQLGhe.ImageOptions.Image = global::GUI.Properties.Resources.add_16x165;
            this.accQLGhe.Name = "accQLGhe";
            this.accQLGhe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLGhe.Text = "Ghế";
            // 
            // accQLDanhGiaDoTuoi
            // 
            this.accQLDanhGiaDoTuoi.Hint = "Quản lý Đánh giá độ tuổi";
            this.accQLDanhGiaDoTuoi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLDanhGiaDoTuoi.Name = "accQLDanhGiaDoTuoi";
            this.accQLDanhGiaDoTuoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLDanhGiaDoTuoi.Text = "Đánh giá độ tuổi";
            // 
            // aceBaoCao
            // 
            this.aceBaoCao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accBaoCaoDoanhThu,
            this.accBaoCaoThuChi,
            this.accBaoCaoTonKho});
            this.aceBaoCao.Expanded = true;
            this.aceBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.report2_32x32;
            this.aceBaoCao.Name = "aceBaoCao";
            this.aceBaoCao.Text = "Báo cáo";
            // 
            // accBaoCaoDoanhThu
            // 
            this.accBaoCaoDoanhThu.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x16;
            this.accBaoCaoDoanhThu.Name = "accBaoCaoDoanhThu";
            this.accBaoCaoDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            // 
            // accBaoCaoThuChi
            // 
            this.accBaoCaoThuChi.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x161;
            this.accBaoCaoThuChi.Name = "accBaoCaoThuChi";
            this.accBaoCaoThuChi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBaoCaoThuChi.Text = "Báo cáo thu chi";
            // 
            // accBaoCaoTonKho
            // 
            this.accBaoCaoTonKho.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x162;
            this.accBaoCaoTonKho.Name = "accBaoCaoTonKho";
            this.accBaoCaoTonKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBaoCaoTonKho.Text = "Báo cáo Tồn Kho";
            // 
            // aceHeThong
            // 
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDangXuat,
            this.accThoat,
            this.accNgonNgu});
            this.aceHeThong.Expanded = true;
            this.aceHeThong.ImageOptions.Image = global::GUI.Properties.Resources.database_32x32;
            this.aceHeThong.Name = "aceHeThong";
            this.aceHeThong.Text = "Hệ thống";
            // 
            // accDangXuat
            // 
            this.accDangXuat.ImageOptions.Image = global::GUI.Properties.Resources.reset_16x161;
            this.accDangXuat.Name = "accDangXuat";
            this.accDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDangXuat.Text = "Đăng xuất";
            this.accDangXuat.Click += new System.EventHandler(this.accDangXuat_Click);
            // 
            // accThoat
            // 
            this.accThoat.ImageOptions.Image = global::GUI.Properties.Resources.close_16x16;
            this.accThoat.Name = "accThoat";
            this.accThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThoat.Text = "Thoát";
            this.accThoat.Click += new System.EventHandler(this.accThoat_Click);
            // 
            // accNgonNgu
            // 
            this.accNgonNgu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accNgonNgu.ImageOptions.Image")));
            this.accNgonNgu.Name = "accNgonNgu";
            this.accNgonNgu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accNgonNgu.Text = "Ngôn ngữ";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1120, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 639);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.arrFunction);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::GUI.Properties.Resources.Logo;
            this.Name = "frmMain";
            this.NavigationControl = this.arrFunction;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTUD: Cinema Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl arrFunction;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDanhMuc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLPhim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLSuatChieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLPhongChieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accBaoCaoDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHeThong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accThoat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLPhanCa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLCaLamViec;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLGhe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accBaoCaoThuChi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accBaoCaoTonKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQLDanhGiaDoTuoi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accDatVe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accNgonNgu;
    }
}