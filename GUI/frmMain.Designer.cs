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
            this.aceDatVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDatVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhongChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSuatChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhanCa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLCaLamViec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLGhe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLDanhGiaDoTuoi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accChiPhi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accLoaiChiPhi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoThuChi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoTonKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accCaiDat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.mainContainer.Location = new System.Drawing.Point(250, 31);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(710, 608);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Click += new System.EventHandler(this.mainContainer_Click);
            // 
            // arrFunction
            // 
            this.arrFunction.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(88)))), ((int)(((byte)(143)))));
            this.arrFunction.Appearance.AccordionControl.Options.UseBackColor = true;
            this.arrFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.arrFunction.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDatVe,
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
            this.arrFunction.Location = new System.Drawing.Point(0, 31);
            this.arrFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrFunction.Name = "arrFunction";
            this.arrFunction.OptionsHamburgerMenu.HighlightRootElements = DevExpress.Utils.DefaultBoolean.True;
            this.arrFunction.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.arrFunction.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.arrFunction.Size = new System.Drawing.Size(250, 608);
            this.arrFunction.TabIndex = 1;
            this.arrFunction.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceDatVe
            // 
            this.aceDatVe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDatVe,
            this.accQLHoaDon});
            this.aceDatVe.Hint = "Đặt vé xem phim";
            this.aceDatVe.ImageOptions.Image = global::GUI.Properties.Resources.Logo32;
            this.aceDatVe.Name = "aceDatVe";
            this.aceDatVe.Text = "Đặt vé";
            // 
            // accDatVe
            // 
            this.accDatVe.ImageOptions.Image = global::GUI.Properties.Resources.coupon;
            this.accDatVe.Name = "accDatVe";
            this.accDatVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDatVe.Text = "Đặt vé";
            // 
            // accQLHoaDon
            // 
            this.accQLHoaDon.Hint = "Quản lý Hóa Đơn";
            this.accQLHoaDon.ImageOptions.Image = global::GUI.Properties.Resources.financial_16x161;
            this.accQLHoaDon.Name = "accQLHoaDon";
            this.accQLHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLHoaDon.Text = "Hóa Đơn";
            // 
            // aceDanhMuc
            // 
            this.aceDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accQLPhim,
            this.accVe,
            this.accQLSanPham,
            this.accQLPhongChieu,
            this.accQLSuatChieu,
            this.accQLNhanVien,
            this.accQLPhanCa,
            this.accQLCaLamViec,
            this.accQLGhe,
            this.accQLDanhGiaDoTuoi,
            this.accChiPhi,
            this.accLoaiChiPhi});
            this.aceDanhMuc.Hint = "Quản lý danh mục";
            this.aceDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDanhMuc.ImageOptions.Image")));
            this.aceDanhMuc.Name = "aceDanhMuc";
            this.aceDanhMuc.Text = "Quản lý danh mục";
            // 
            // accQLPhim
            // 
            this.accQLPhim.Hint = "Quản Lý Phim";
            this.accQLPhim.ImageOptions.Image = global::GUI.Properties.Resources.add_16x164;
            this.accQLPhim.Name = "accQLPhim";
            this.accQLPhim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhim.Text = "Phim";
            // 
            // accVe
            // 
            this.accVe.ImageOptions.Image = global::GUI.Properties.Resources.add_16x169;
            this.accVe.Name = "accVe";
            this.accVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accVe.Text = "Vé";
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
            this.accQLGhe.Visible = false;
            // 
            // accQLDanhGiaDoTuoi
            // 
            this.accQLDanhGiaDoTuoi.Hint = "Quản lý Đánh giá độ tuổi";
            this.accQLDanhGiaDoTuoi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLDanhGiaDoTuoi.Name = "accQLDanhGiaDoTuoi";
            this.accQLDanhGiaDoTuoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLDanhGiaDoTuoi.Text = "Đánh giá độ tuổi";
            // 
            // accChiPhi
            // 
            this.accChiPhi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x16;
            this.accChiPhi.Name = "accChiPhi";
            this.accChiPhi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accChiPhi.Text = "Chi phí";
            // 
            // accLoaiChiPhi
            // 
            this.accLoaiChiPhi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x16;
            this.accLoaiChiPhi.Name = "accLoaiChiPhi";
            this.accLoaiChiPhi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accLoaiChiPhi.Text = "Loại chi phí";
            // 
            // aceBaoCao
            // 
            this.aceBaoCao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accBaoCaoDoanhThu,
            this.accBaoCaoThuChi,
            this.accBaoCaoTonKho});
            this.aceBaoCao.Expanded = true;
            this.aceBaoCao.Hint = "Báo cáo số liệu";
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
            this.accBaoCaoThuChi.Text = "Báo cáo chi phí";
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
            this.accCaiDat,
            this.accDangXuat,
            this.accThoat});
            this.aceHeThong.ImageOptions.Image = global::GUI.Properties.Resources.properties_32x32;
            this.aceHeThong.Name = "aceHeThong";
            this.aceHeThong.Text = "Hệ thống";
            // 
            // accCaiDat
            // 
            this.accCaiDat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accCaiDat.ImageOptions.Image")));
            this.accCaiDat.Name = "accCaiDat";
            this.accCaiDat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accCaiDat.Text = "Cài đặt";
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
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(960, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 639);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.arrFunction);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::GUI.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement accVe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accChiPhi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accLoaiChiPhi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accCaiDat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDatVe;
    }
}