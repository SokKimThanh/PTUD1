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
            this.lblTime = new DevExpress.XtraBars.BarHeaderItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.arrFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            resources.ApplyResources(this.mainContainer, "mainContainer");
            this.mainContainer.Name = "mainContainer";
            // 
            // arrFunction
            // 
            resources.ApplyResources(this.arrFunction, "arrFunction");
            this.arrFunction.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(88)))), ((int)(((byte)(143)))));
            this.arrFunction.Appearance.AccordionControl.Options.UseBackColor = true;
            this.arrFunction.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDatVe,
            this.aceDanhMuc,
            this.aceBaoCao,
            this.aceHeThong});
            this.arrFunction.Name = "arrFunction";
            this.arrFunction.OptionsHamburgerMenu.HighlightRootElements = DevExpress.Utils.DefaultBoolean.True;
            this.arrFunction.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.arrFunction.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.arrFunction.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.arrFunction.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.arrFunction.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.arrFunction_ElementClick);
            // 
            // aceDatVe
            // 
            resources.ApplyResources(this.aceDatVe, "aceDatVe");
            this.aceDatVe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDatVe,
            this.accQLHoaDon});
            this.aceDatVe.ImageOptions.Image = global::GUI.Properties.Resources.Logo32;
            this.aceDatVe.Name = "aceDatVe";
            // 
            // accDatVe
            // 
            resources.ApplyResources(this.accDatVe, "accDatVe");
            this.accDatVe.ImageOptions.Image = global::GUI.Properties.Resources.coupon;
            this.accDatVe.Name = "accDatVe";
            this.accDatVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLHoaDon
            // 
            resources.ApplyResources(this.accQLHoaDon, "accQLHoaDon");
            this.accQLHoaDon.ImageOptions.Image = global::GUI.Properties.Resources.financial_16x161;
            this.accQLHoaDon.Name = "accQLHoaDon";
            this.accQLHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // aceDanhMuc
            // 
            resources.ApplyResources(this.aceDanhMuc, "aceDanhMuc");
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
            this.aceDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDanhMuc.ImageOptions.Image")));
            this.aceDanhMuc.Name = "aceDanhMuc";
            // 
            // accQLPhim
            // 
            resources.ApplyResources(this.accQLPhim, "accQLPhim");
            this.accQLPhim.ImageOptions.Image = global::GUI.Properties.Resources.add_16x164;
            this.accQLPhim.Name = "accQLPhim";
            this.accQLPhim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accVe
            // 
            resources.ApplyResources(this.accVe, "accVe");
            this.accVe.ImageOptions.Image = global::GUI.Properties.Resources.add_16x169;
            this.accVe.Name = "accVe";
            this.accVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLSanPham
            // 
            resources.ApplyResources(this.accQLSanPham, "accQLSanPham");
            this.accQLSanPham.ImageOptions.Image = global::GUI.Properties.Resources.add_16x167;
            this.accQLSanPham.Name = "accQLSanPham";
            this.accQLSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLPhongChieu
            // 
            resources.ApplyResources(this.accQLPhongChieu, "accQLPhongChieu");
            this.accQLPhongChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x168;
            this.accQLPhongChieu.Name = "accQLPhongChieu";
            this.accQLPhongChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLSuatChieu
            // 
            resources.ApplyResources(this.accQLSuatChieu, "accQLSuatChieu");
            this.accQLSuatChieu.ImageOptions.Image = global::GUI.Properties.Resources.add_16x169;
            this.accQLSuatChieu.Name = "accQLSuatChieu";
            this.accQLSuatChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLNhanVien
            // 
            resources.ApplyResources(this.accQLNhanVien, "accQLNhanVien");
            this.accQLNhanVien.ImageOptions.Image = global::GUI.Properties.Resources.add_16x163;
            this.accQLNhanVien.Name = "accQLNhanVien";
            this.accQLNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLPhanCa
            // 
            resources.ApplyResources(this.accQLPhanCa, "accQLPhanCa");
            this.accQLPhanCa.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLPhanCa.Name = "accQLPhanCa";
            this.accQLPhanCa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLCaLamViec
            // 
            resources.ApplyResources(this.accQLCaLamViec, "accQLCaLamViec");
            this.accQLCaLamViec.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLCaLamViec.Name = "accQLCaLamViec";
            this.accQLCaLamViec.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accQLGhe
            // 
            resources.ApplyResources(this.accQLGhe, "accQLGhe");
            this.accQLGhe.ImageOptions.Image = global::GUI.Properties.Resources.add_16x165;
            this.accQLGhe.Name = "accQLGhe";
            this.accQLGhe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQLGhe.Visible = false;
            // 
            // accQLDanhGiaDoTuoi
            // 
            resources.ApplyResources(this.accQLDanhGiaDoTuoi, "accQLDanhGiaDoTuoi");
            this.accQLDanhGiaDoTuoi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x1610;
            this.accQLDanhGiaDoTuoi.Name = "accQLDanhGiaDoTuoi";
            this.accQLDanhGiaDoTuoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accChiPhi
            // 
            resources.ApplyResources(this.accChiPhi, "accChiPhi");
            this.accChiPhi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x16;
            this.accChiPhi.Name = "accChiPhi";
            this.accChiPhi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accLoaiChiPhi
            // 
            resources.ApplyResources(this.accLoaiChiPhi, "accLoaiChiPhi");
            this.accLoaiChiPhi.ImageOptions.Image = global::GUI.Properties.Resources.add_16x16;
            this.accLoaiChiPhi.Name = "accLoaiChiPhi";
            this.accLoaiChiPhi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // aceBaoCao
            // 
            resources.ApplyResources(this.aceBaoCao, "aceBaoCao");
            this.aceBaoCao.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accBaoCaoDoanhThu,
            this.accBaoCaoThuChi,
            this.accBaoCaoTonKho});
            this.aceBaoCao.Expanded = true;
            this.aceBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.report2_32x32;
            this.aceBaoCao.Name = "aceBaoCao";
            // 
            // accBaoCaoDoanhThu
            // 
            resources.ApplyResources(this.accBaoCaoDoanhThu, "accBaoCaoDoanhThu");
            this.accBaoCaoDoanhThu.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x16;
            this.accBaoCaoDoanhThu.Name = "accBaoCaoDoanhThu";
            this.accBaoCaoDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accBaoCaoThuChi
            // 
            resources.ApplyResources(this.accBaoCaoThuChi, "accBaoCaoThuChi");
            this.accBaoCaoThuChi.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x161;
            this.accBaoCaoThuChi.Name = "accBaoCaoThuChi";
            this.accBaoCaoThuChi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accBaoCaoTonKho
            // 
            resources.ApplyResources(this.accBaoCaoTonKho, "accBaoCaoTonKho");
            this.accBaoCaoTonKho.ImageOptions.Image = global::GUI.Properties.Resources.boreport_16x162;
            this.accBaoCaoTonKho.Name = "accBaoCaoTonKho";
            this.accBaoCaoTonKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // aceHeThong
            // 
            resources.ApplyResources(this.aceHeThong, "aceHeThong");
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accCaiDat,
            this.accDangXuat,
            this.accThoat});
            this.aceHeThong.ImageOptions.Image = global::GUI.Properties.Resources.properties_32x32;
            this.aceHeThong.Name = "aceHeThong";
            // 
            // accCaiDat
            // 
            resources.ApplyResources(this.accCaiDat, "accCaiDat");
            this.accCaiDat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accCaiDat.ImageOptions.Image")));
            this.accCaiDat.Name = "accCaiDat";
            this.accCaiDat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accDangXuat
            // 
            resources.ApplyResources(this.accDangXuat, "accDangXuat");
            this.accDangXuat.ImageOptions.Image = global::GUI.Properties.Resources.reset_16x161;
            this.accDangXuat.Name = "accDangXuat";
            this.accDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accDangXuat.Click += new System.EventHandler(this.accDangXuat_Click);
            // 
            // accThoat
            // 
            resources.ApplyResources(this.accThoat, "accThoat");
            this.accThoat.ImageOptions.Image = global::GUI.Properties.Resources.close_16x16;
            this.accThoat.Name = "accThoat";
            this.accThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThoat.Click += new System.EventHandler(this.accThoat_Click);
            // 
            // fluentDesignFormControl1
            // 
            resources.ApplyResources(this.fluentDesignFormControl1, "fluentDesignFormControl1");
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTime});
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTime);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Id = 0;
            this.lblTime.ImageOptions.ImageIndex = ((int)(resources.GetObject("lblTime.ImageOptions.ImageIndex")));
            this.lblTime.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("lblTime.ImageOptions.LargeImageIndex")));
            this.lblTime.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblTime.ImageOptions.SvgImage")));
            this.lblTime.Name = "lblTime";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTime});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.arrFunction);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::GUI.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.NavigationControl = this.arrFunction;
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
        private DevExpress.XtraBars.BarHeaderItem lblTime;
    }
}