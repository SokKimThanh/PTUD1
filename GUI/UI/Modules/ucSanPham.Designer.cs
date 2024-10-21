using DevExpress.Utils;

namespace GUI.UI.Modules
{
    partial class ucSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.ActionBar = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.btnOpenImage = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaTien = new DevExpress.XtraEditors.TextEdit();
            this.txtUrlHinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTenSP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutGia = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutBtnHinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutSoLuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrlHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.ActionBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnCapNhat,
            this.btnLamMoi});
            this.barManager1.MainMenu = this.ActionBar;
            this.barManager1.MaxItemId = 4;
            // 
            // ActionBar
            // 
            this.ActionBar.BarName = "Main menu";
            this.ActionBar.DockCol = 0;
            this.ActionBar.DockRow = 0;
            this.ActionBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ActionBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapNhat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.MultiLine = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm mới";
            this.btnThem.Hint = "Thêm mới";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::GUI.Properties.Resources.insert_16x16;
            this.btnThem.ImageOptions.LargeImage = global::GUI.Properties.Resources.insert_32x32;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Hint = "Xóa dữ liệu";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = global::GUI.Properties.Resources.deletelist_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::GUI.Properties.Resources.deletelist_32x32;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Hint = "Cập nhật dữ liệu";
            this.btnCapNhat.Id = 2;
            this.btnCapNhat.ImageOptions.Image = global::GUI.Properties.Resources.edit_16x161;
            this.btnCapNhat.ImageOptions.LargeImage = global::GUI.Properties.Resources.edit_32x321;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Hint = "Làm mới dữ liệu";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = global::GUI.Properties.Resources.refreshpivottable_16x16;
            this.btnLamMoi.ImageOptions.LargeImage = global::GUI.Properties.Resources.refreshpivottable_32x32;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(795, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(795, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(795, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.btnOpenImage);
            this.layoutForm.Controls.Add(this.pictureBox);
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgv);
            this.layoutForm.Controls.Add(this.txtTenSanPham);
            this.layoutForm.Controls.Add(this.txtGiaTien);
            this.layoutForm.Controls.Add(this.txtUrlHinhAnh);
            this.layoutForm.Controls.Add(this.txtSoLuong);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 24);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(526, 304, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(795, 527);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenImage.Appearance.Options.UseFont = true;
            this.btnOpenImage.Location = new System.Drawing.Point(24, 247);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(125, 22);
            this.btnOpenImage.StyleController = this.layoutForm;
            this.btnOpenImage.TabIndex = 14;
            this.btnOpenImage.Text = "Chọn hình ảnh";
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(24, 87);
            this.pictureBox.MenuManager = this.barManager1;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox.Size = new System.Drawing.Size(125, 156);
            this.pictureBox.StyleController = this.layoutForm;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(759, 26);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(24, 318);
            this.dgv.MainView = this.gridView1;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(747, 185);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(153, 103);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(618, 20);
            this.txtTenSanPham.StyleController = this.layoutForm;
            this.txtTenSanPham.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(153, 183);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Properties.BeepOnError = true;
            this.txtGiaTien.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiaTien.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtGiaTien.Properties.MaskSettings.Set("mask", "d");
            this.txtGiaTien.Properties.MaskSettings.Set("culture", "vi-VN");
            this.txtGiaTien.Properties.MaskSettings.Set("valueType", typeof(double));
            this.txtGiaTien.Properties.UseMaskAsDisplayFormat = true;
            this.txtGiaTien.Size = new System.Drawing.Size(618, 20);
            this.txtGiaTien.StyleController = this.layoutForm;
            this.txtGiaTien.TabIndex = 11;
            // 
            // txtUrlHinhAnh
            // 
            this.txtUrlHinhAnh.Location = new System.Drawing.Point(153, 223);
            this.txtUrlHinhAnh.MenuManager = this.barManager1;
            this.txtUrlHinhAnh.Name = "txtUrlHinhAnh";
            this.txtUrlHinhAnh.Size = new System.Drawing.Size(618, 20);
            this.txtUrlHinhAnh.StyleController = this.layoutForm;
            this.txtUrlHinhAnh.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(153, 143);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.BeepOnError = true;
            this.txtSoLuong.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSoLuong.Properties.MaskSettings.Set("mask", "d");
            this.txtSoLuong.Properties.MaskSettings.Set("culture", "vi-VN");
            this.txtSoLuong.Properties.UseMaskAsDisplayFormat = true;
            this.txtSoLuong.Size = new System.Drawing.Size(618, 20);
            this.txtSoLuong.StyleController = this.layoutForm;
            this.txtSoLuong.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutAction,
            this.layoutDGV});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(795, 527);
            this.Root.TextVisible = false;
            // 
            // layoutTitle
            // 
            this.layoutTitle.Control = this.lblTitle;
            this.layoutTitle.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle.Size = new System.Drawing.Size(775, 42);
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle.Text = "Title";
            this.layoutTitle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTitle.TextVisible = false;
            // 
            // layoutAction
            // 
            this.layoutAction.CaptionImageOptions.Image = global::GUI.Properties.Resources.reviewallowuserstoeditranges_16x16;
            this.layoutAction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutTenSP,
            this.layoutGia,
            this.layoutBtnHinh,
            this.layoutSoLuong});
            this.layoutAction.Location = new System.Drawing.Point(0, 42);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(775, 231);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtUrlHinhAnh;
            this.layoutControlItem2.Location = new System.Drawing.Point(129, 120);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(622, 66);
            this.layoutControlItem2.Text = "Product URL:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pictureBox;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(129, 160);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(129, 160);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(129, 160);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Hình ảnh sản phẩm:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutTenSP
            // 
            this.layoutTenSP.Control = this.txtTenSanPham;
            this.layoutTenSP.CustomizationFormText = "Tên sản phẩm:";
            this.layoutTenSP.Location = new System.Drawing.Point(129, 0);
            this.layoutTenSP.Name = "layoutTenSP";
            this.layoutTenSP.Size = new System.Drawing.Size(622, 40);
            this.layoutTenSP.Text = "Tên sản phẩm:";
            this.layoutTenSP.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTenSP.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutGia
            // 
            this.layoutGia.Control = this.txtGiaTien;
            this.layoutGia.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutGia.CustomizationFormText = "Giá:";
            this.layoutGia.Location = new System.Drawing.Point(129, 80);
            this.layoutGia.Name = "layoutGia";
            this.layoutGia.Size = new System.Drawing.Size(622, 40);
            this.layoutGia.Text = "Giá:";
            this.layoutGia.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutGia.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutBtnHinh
            // 
            this.layoutBtnHinh.Control = this.btnOpenImage;
            this.layoutBtnHinh.Location = new System.Drawing.Point(0, 160);
            this.layoutBtnHinh.Name = "layoutBtnHinh";
            this.layoutBtnHinh.Size = new System.Drawing.Size(129, 26);
            this.layoutBtnHinh.Text = "Nút Thêm Hình";
            this.layoutBtnHinh.TextSize = new System.Drawing.Size(0, 0);
            this.layoutBtnHinh.TextVisible = false;
            // 
            // layoutSoLuong
            // 
            this.layoutSoLuong.Control = this.txtSoLuong;
            this.layoutSoLuong.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutSoLuong.CustomizationFormText = "Số lượng:";
            this.layoutSoLuong.Location = new System.Drawing.Point(129, 40);
            this.layoutSoLuong.Name = "layoutSoLuong";
            this.layoutSoLuong.Size = new System.Drawing.Size(622, 40);
            this.layoutSoLuong.Text = "Số lượng:";
            this.layoutSoLuong.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutSoLuong.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutDGV
            // 
            this.layoutDGV.CaptionImageOptions.Image = global::GUI.Properties.Resources.newtablestyle_16x16;
            this.layoutDGV.CustomizationFormText = "Danh sách dữ liệu";
            this.layoutDGV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutDGV.Location = new System.Drawing.Point(0, 273);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(775, 234);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(751, 189);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(795, 551);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrlHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar ActionBar;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutTenSP;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtGiaTien;
        private DevExpress.XtraLayout.LayoutControlItem layoutGia;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraEditors.TextEdit txtUrlHinhAnh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnOpenImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutBtnHinh;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutSoLuong;
    }
}
