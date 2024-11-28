using DevExpress.Utils;

namespace GUI.UI.Modules
{
    partial class ucPhim
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
            this.txtDescription = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnOpenImage = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtDurations = new DevExpress.XtraEditors.TextEdit();
            this.cboAgeRating = new DevExpress.XtraEditors.LookUpEdit();
            this.cboStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAgeRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1032, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 906);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1032, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 876);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1032, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 876);
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.txtDescription);
            this.layoutForm.Controls.Add(this.btnOpenImage);
            this.layoutForm.Controls.Add(this.pictureBox);
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgv);
            this.layoutForm.Controls.Add(this.txtName);
            this.layoutForm.Controls.Add(this.txtPrice);
            this.layoutForm.Controls.Add(this.txtDurations);
            this.layoutForm.Controls.Add(this.cboAgeRating);
            this.layoutForm.Controls.Add(this.cboStatus);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 30);
            this.layoutForm.Margin = new System.Windows.Forms.Padding(4);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(495, 114, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(1032, 876);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(683, 113);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MenuManager = this.barManager1;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(325, 221);
            this.txtDescription.TabIndex = 18;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenImage.Appearance.Options.UseFont = true;
            this.btnOpenImage.Location = new System.Drawing.Point(31, 299);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenImage.MaximumSize = new System.Drawing.Size(0, 39);
            this.btnOpenImage.MinimumSize = new System.Drawing.Size(0, 39);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(122, 39);
            this.btnOpenImage.StyleController = this.layoutForm;
            this.btnOpenImage.TabIndex = 17;
            this.btnOpenImage.Text = "Chọn hình ảnh";
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(24, 94);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.MenuManager = this.barManager1;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureBox.Size = new System.Drawing.Size(136, 193);
            this.pictureBox.StyleController = this.layoutForm;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgv
            // 
            this.dgv.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.Location = new System.Drawing.Point(24, 388);
            this.dgv.MainView = this.gridView1;
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(984, 464);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(501, 22);
            this.txtName.StyleController = this.layoutForm;
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(171, 304);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MenuManager = this.barManager1;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.BeepOnError = true;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrice.Properties.MaskSettings.Set("mask", "d");
            this.txtPrice.Properties.MaskSettings.Set("culture", "vi");
            this.txtPrice.Properties.MaskSettings.Set("valueType", typeof(double));
            this.txtPrice.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrice.Size = new System.Drawing.Size(501, 22);
            this.txtPrice.StyleController = this.layoutForm;
            this.txtPrice.TabIndex = 10;
            // 
            // txtDurations
            // 
            this.txtDurations.Location = new System.Drawing.Point(171, 243);
            this.txtDurations.Margin = new System.Windows.Forms.Padding(4);
            this.txtDurations.MenuManager = this.barManager1;
            this.txtDurations.Name = "txtDurations";
            this.txtDurations.Properties.BeepOnError = true;
            this.txtDurations.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDurations.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDurations.Properties.MaskSettings.Set("mask", "d");
            this.txtDurations.Properties.MaskSettings.Set("culture", "vi-VN");
            this.txtDurations.Properties.UseMaskAsDisplayFormat = true;
            this.txtDurations.Size = new System.Drawing.Size(501, 22);
            this.txtDurations.StyleController = this.layoutForm;
            this.txtDurations.TabIndex = 14;
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.EditValue = "--Chọn đánh giá";
            this.cboAgeRating.Location = new System.Drawing.Point(171, 182);
            this.cboAgeRating.Margin = new System.Windows.Forms.Padding(4);
            this.cboAgeRating.MenuManager = this.barManager1;
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAgeRating.Properties.NullText = "";
            this.cboAgeRating.Properties.PopupSizeable = false;
            this.cboAgeRating.Size = new System.Drawing.Size(501, 22);
            this.cboAgeRating.StyleController = this.layoutForm;
            this.cboAgeRating.TabIndex = 11;
            this.cboAgeRating.EditValueChanged += new System.EventHandler(this.cboAgeRating_EditValueChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.Location = new System.Drawing.Point(633, 21);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.DropDownRows = 2;
            this.cboStatus.Properties.NullText = "";
            this.cboStatus.Size = new System.Drawing.Size(387, 22);
            this.cboStatus.StyleController = this.layoutForm;
            this.cboStatus.TabIndex = 5;
            this.cboStatus.EditValueChanged += new System.EventHandler(this.cboStatus_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutAction,
            this.layoutDGV,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1032, 876);
            this.Root.TextVisible = false;
            // 
            // layoutTitle
            // 
            this.layoutTitle.Control = this.lblTitle;
            this.layoutTitle.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 44);
            this.layoutTitle.MinSize = new System.Drawing.Size(42, 44);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutTitle.Size = new System.Drawing.Size(506, 44);
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutTitle.Text = "Title";
            this.layoutTitle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTitle.TextVisible = false;
            // 
            // layoutAction
            // 
            this.layoutAction.CaptionImageOptions.Image = global::GUI.Properties.Resources.reviewallowuserstoeditranges_16x16;
            this.layoutAction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem10,
            this.layoutControlItem5,
            this.layoutControlItem9});
            this.layoutAction.Location = new System.Drawing.Point(0, 44);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(1012, 294);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.CustomizationFormText = "Tên Phim:";
            this.layoutControlItem2.Location = new System.Drawing.Point(140, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(519, 61);
            this.layoutControlItem2.Text = "Tên Phim:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtDurations;
            this.layoutControlItem7.Location = new System.Drawing.Point(140, 122);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 10, 10);
            this.layoutControlItem7.Size = new System.Drawing.Size(519, 61);
            this.layoutControlItem7.Text = "Nhập số phút:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.pictureBox;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(140, 197);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(140, 197);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(140, 197);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "Hình ảnh:";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cboAgeRating;
            this.layoutControlItem6.Location = new System.Drawing.Point(140, 61);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(519, 61);
            this.layoutControlItem6.Text = "Đánh giá lứa tuổi:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtDescription;
            this.layoutControlItem10.Location = new System.Drawing.Point(659, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(329, 244);
            this.layoutControlItem10.Text = "Mô tả:";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtPrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(140, 183);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(519, 61);
            this.layoutControlItem5.Text = "Giá vé:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(103, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseBorderColor = true;
            this.layoutControlItem9.Control = this.btnOpenImage;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 197);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(105, 32);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 10, 10);
            this.layoutControlItem9.Size = new System.Drawing.Size(140, 47);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "ThemHinh";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutDGV
            // 
            this.layoutDGV.CaptionImageOptions.Image = global::GUI.Properties.Resources.newtablestyle_16x16;
            this.layoutDGV.CustomizationFormText = "Danh sách dữ liệu";
            this.layoutDGV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutDGV.Location = new System.Drawing.Point(0, 338);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(1012, 518);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(988, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem3.Control = this.cboStatus;
            this.layoutControlItem3.Location = new System.Drawing.Point(506, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(506, 44);
            this.layoutControlItem3.Text = "Trạng thái:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 16);
            // 
            // ucPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPhim";
            this.Size = new System.Drawing.Size(1032, 906);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAgeRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtDurations;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit cboAgeRating;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnOpenImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraRichEdit.RichEditControl txtDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LookUpEdit cboStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
