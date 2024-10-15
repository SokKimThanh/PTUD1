namespace GUI
{
    partial class frmMainForm
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
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDatVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhongChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLSuatChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLCaLamViec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLPhanCa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLGhe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQLDanhGiaDoTuoi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoThuChi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBaoCaoTonKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(700, 683);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 683);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceDanhMuc
            // 
            this.aceDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDatVe,
            this.accQLHoaDon,
            this.accQLPhanCa,
            this.accQLNhanVien,
            this.accQLCaLamViec,
            this.accQLPhim,
            this.accQLDanhGiaDoTuoi,
            this.accQLSanPham,
            this.accQLPhongChieu,
            this.accQLSuatChieu,
            this.accQLGhe});
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
            // accQLHoaDon
            // 
            this.accQLHoaDon.Hint = "Quản lý Hóa Đơn";
            this.accQLHoaDon.ImageOptions.Image = global::GUI.Properties.Resources.apply_16x16;
            this.accQLHoaDon.Name = "accQLHoaDon";
            this.accQLHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLHoaDon.Text = "QL Hóa Đơn";
            this.accQLHoaDon.Click += new System.EventHandler(this.accQLHoaDon_Click);
            // 
            // accQLPhim
            // 
            this.accQLPhim.Hint = "Quản Lý Phim";
            this.accQLPhim.ImageOptions.Image = global::GUI.Properties.Resources.add_16x164;
            this.accQLPhim.Name = "accQLPhim";
            this.accQLPhim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhim.Text = "QL Phim";
            this.accQLPhim.Click += new System.EventHandler(this.accQLPhim_Click);
            // 
            // accQLSanPham
            // 
            this.accQLSanPham.Hint = "Quản Lý Sản Phẩm";
            this.accQLSanPham.ImageOptions.Image = global::GUI.Properties.Resources.add_16x167;
            this.accQLSanPham.Name = "accQLSanPham";
            this.accQLSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLSanPham.Text = "QL Sản Phẩm";
            this.accQLSanPham.Click += new System.EventHandler(this.accQLSanPham_Click);
            // 
            // accQLPhongChieu
            // 
            this.accQLPhongChieu.Hint = "Quản Lý Phòng Chiếu";
            this.accQLPhongChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x168;
            this.accQLPhongChieu.Name = "accQLPhongChieu";
            this.accQLPhongChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhongChieu.Text = "QL Phòng Chiếu";
            this.accQLPhongChieu.Click += new System.EventHandler(this.accQLPhongChieu_Click);
            // 
            // accQLSuatChieu
            // 
            this.accQLSuatChieu.Hint = "Quản Lý Suất Chiếu";
            this.accQLSuatChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x169;
            this.accQLSuatChieu.Name = "accQLSuatChieu";
            this.accQLSuatChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLSuatChieu.Text = "QL Suất Chiếu";
            this.accQLSuatChieu.Click += new System.EventHandler(this.accQLSuatChieu_Click);
            // 
            // accQLNhanVien
            // 
            this.accQLNhanVien.Hint = "Quản Lý Nhân Viên";
            this.accQLNhanVien.ImageOptions.Image = global::GUI.Properties.Resources.add_16x163;
            this.accQLNhanVien.Name = "accQLNhanVien";
            this.accQLNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLNhanVien.Text = "QL Nhân Viên";
            this.accQLNhanVien.Click += new System.EventHandler(this.accQLNhanVien_Click);
            // 
            // accQLCaLamViec
            // 
            this.accQLCaLamViec.Hint = "Quản lý Ca Làm Việc";
            this.accQLCaLamViec.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLCaLamViec.Name = "accQLCaLamViec";
            this.accQLCaLamViec.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLCaLamViec.Text = "QL Ca Làm Việc";
            this.accQLCaLamViec.Click += new System.EventHandler(this.accQLCaLamViec_Click);
            // 
            // accQLPhanCa
            // 
            this.accQLPhanCa.Hint = "Phân Ca Làm việc nhân viên";
            this.accQLPhanCa.ImageOptions.Image = global::GUI.Properties.Resources.apply_16x162;
            this.accQLPhanCa.Name = "accQLPhanCa";
            this.accQLPhanCa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLPhanCa.Text = "Phân Ca";
            this.accQLPhanCa.Click += new System.EventHandler(this.accQLPhanCa_Click);
            // 
            // accQLGhe
            // 
            this.accQLGhe.Hint = "Quản lý ghế";
            this.accQLGhe.ImageOptions.Image = global::GUI.Properties.Resources.add_16x165;
            this.accQLGhe.Name = "accQLGhe";
            this.accQLGhe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLGhe.Text = "QL ghế";
            this.accQLGhe.Click += new System.EventHandler(this.accQLGhe_Click);
            // 
            // accQLDanhGiaDoTuoi
            // 
            this.accQLDanhGiaDoTuoi.Hint = "Quản lý Đánh giá độ tuổi";
            this.accQLDanhGiaDoTuoi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLDanhGiaDoTuoi.Name = "accQLDanhGiaDoTuoi";
            this.accQLDanhGiaDoTuoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLDanhGiaDoTuoi.Text = "QL Đánh giá độ tuổi";
            this.accQLDanhGiaDoTuoi.Click += new System.EventHandler(this.accQLDanhGiaDoTuoi_Click);
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
            this.accBaoCaoDoanhThu.Click += new System.EventHandler(this.accBaoCaoDoanhThu_Click);
            // 
            // accBaoCaoThuChi
            // 
            this.accBaoCaoThuChi.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x161;
            this.accBaoCaoThuChi.Name = "accBaoCaoThuChi";
            this.accBaoCaoThuChi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBaoCaoThuChi.Text = "Báo cáo thu chi";
            this.accBaoCaoThuChi.Click += new System.EventHandler(this.accBaoCaoThuChi_Click);
            // 
            // accBaoCaoTonKho
            // 
            this.accBaoCaoTonKho.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x162;
            this.accBaoCaoTonKho.Name = "accBaoCaoTonKho";
            this.accBaoCaoTonKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBaoCaoTonKho.Text = "Báo cáo Tồn Kho";
            this.accBaoCaoTonKho.Click += new System.EventHandler(this.accBaoCaoTonKho_Click);
            // 
            // aceHeThong
            // 
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDangXuat,
            this.accThoat});
            this.aceHeThong.Expanded = true;
            this.aceHeThong.ImageOptions.Image = global::GUI.Properties.Resources.database_32x32;
            this.aceHeThong.Name = "aceHeThong";
            this.aceHeThong.Text = "Hệ thống";
            // 
            // accDangXuat
            // 
            this.accDangXuat.ImageOptions.Image = global::GUI.Properties.Resources.pause_16x16;
            this.accDangXuat.Name = "accDangXuat";
            this.accDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDangXuat.Text = "Đăng xuất";
            this.accDangXuat.Click += new System.EventHandler(this.accDangXuat_Click);
            // 
            // accThoat
            // 
            this.accThoat.ImageOptions.Image = global::GUI.Properties.Resources.iconsetquarters5_16x16;
            this.accThoat.Name = "accThoat";
            this.accThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThoat.Text = "Thoát";
            this.accThoat.Click += new System.EventHandler(this.accThoatVaDangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(960, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 714);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::GUI.Properties.Resources.Logo;
            this.Name = "frmMainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTUD: Cinema Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
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
    }
}