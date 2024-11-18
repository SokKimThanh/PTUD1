namespace GUI.UI.Modules
{
    partial class ucChonPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChonPhim));
            this.btnThucThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.dgvMovies = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.btnTiepTuc = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtThoiLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtAgeRating = new DevExpress.XtraEditors.TextEdit();
            this.cboMovieSchedule = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.txtTenPhim = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhim = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTenPhim = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMaPhim = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutThoiLuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ActionBar = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeRating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMovieSchedule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThoiLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThucThi
            // 
            this.btnThucThi.Caption = "Thực thi";
            this.btnThucThi.Hint = "Hiển thị kết quả";
            this.btnThucThi.Id = 0;
            this.btnThucThi.ImageOptions.Image = global::GUI.Properties.Resources.play_16x16;
            this.btnThucThi.ImageOptions.LargeImage = global::GUI.Properties.Resources.play_32x32;
            this.btnThucThi.Name = "btnThucThi";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Caption = "Tạo báo cáo";
            this.btnTaoBaoCao.Hint = "Xóa dữ liệu";
            this.btnTaoBaoCao.Id = 1;
            this.btnTaoBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.boreport2_16x161;
            this.btnTaoBaoCao.ImageOptions.LargeImage = global::GUI.Properties.Resources.boreport2_32x321;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Hint = "Làm mới dữ liệu";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = global::GUI.Properties.Resources.refreshpivottable_16x16;
            this.btnLamMoi.ImageOptions.LargeImage = global::GUI.Properties.Resources.refreshpivottable_32x32;
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1037, 24);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 762);
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.dgvMovies);
            this.layoutForm.Controls.Add(this.btnTiepTuc);
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.txtThoiLuong);
            this.layoutForm.Controls.Add(this.txtAgeRating);
            this.layoutForm.Controls.Add(this.cboMovieSchedule);
            this.layoutForm.Controls.Add(this.dtpDate);
            this.layoutForm.Controls.Add(this.txtTenPhim);
            this.layoutForm.Controls.Add(this.txtMaPhim);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 24);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(580, 328, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(1037, 762);
            this.layoutForm.TabIndex = 10;
            this.layoutForm.Text = "layoutControl1";
            // 
            // dgvMovies
            // 
            this.dgvMovies.Location = new System.Drawing.Point(12, 203);
            this.dgvMovies.MainView = this.layoutView1;
            this.dgvMovies.MenuManager = this.barManager1;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(1013, 468);
            this.dgvMovies.TabIndex = 16;
            this.dgvMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            this.dgvMovies.DataSourceChanged += new System.EventHandler(this.dgvMovies_DataSourceChanged);
            this.dgvMovies.Click += new System.EventHandler(this.dgvMovies_Click);
            // 
            // layoutView1
            // 
            this.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutView1.CardHorzInterval = 3;
            this.layoutView1.CardMinSize = new System.Drawing.Size(300, 350);
            this.layoutView1.CardVertInterval = 0;
            this.layoutView1.GridControl = this.dgvMovies;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutView1_CustomUnboundColumnData);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hủy";
            this.barButtonItem2.Hint = "Hủy bỏ chọn phim";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::GUI.Properties.Resources.cancel_16x161;
            this.barButtonItem2.ImageOptions.LargeImage = global::GUI.Properties.Resources.cancel_32x321;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm mới";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::GUI.Properties.Resources.refreshallpivottable_16x16;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1037, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 786);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1037, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 762);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1037, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 762);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Appearance.Options.UseFont = true;
            this.btnTiepTuc.Location = new System.Drawing.Point(774, 693);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(233, 28);
            this.btnTiepTuc.StyleController = this.layoutForm;
            this.btnTiepTuc.TabIndex = 15;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiep_Tuc_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1001, 26);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Enabled = false;
            this.txtThoiLuong.Location = new System.Drawing.Point(526, 161);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Properties.DisplayFormat.FormatString = "d";
            this.txtThoiLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtThoiLuong.Properties.EditFormat.FormatString = "d";
            this.txtThoiLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtThoiLuong.Size = new System.Drawing.Size(481, 20);
            this.txtThoiLuong.StyleController = this.layoutForm;
            this.txtThoiLuong.TabIndex = 12;
            // 
            // txtAgeRating
            // 
            this.txtAgeRating.Enabled = false;
            this.txtAgeRating.Location = new System.Drawing.Point(526, 109);
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.Properties.DisplayFormat.FormatString = "d";
            this.txtAgeRating.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtAgeRating.Properties.EditFormat.FormatString = "d";
            this.txtAgeRating.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtAgeRating.Size = new System.Drawing.Size(481, 20);
            this.txtAgeRating.StyleController = this.layoutForm;
            this.txtAgeRating.TabIndex = 12;
            // 
            // cboMovieSchedule
            // 
            this.cboMovieSchedule.EditValue = "<Null>";
            this.cboMovieSchedule.Location = new System.Drawing.Point(278, 712);
            this.cboMovieSchedule.Name = "cboMovieSchedule";
            this.cboMovieSchedule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMovieSchedule.Properties.DisplayFormat.FormatString = "d";
            this.cboMovieSchedule.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboMovieSchedule.Properties.EditFormat.FormatString = "hh:mm:ss";
            this.cboMovieSchedule.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboMovieSchedule.Properties.NullText = "";
            this.cboMovieSchedule.Size = new System.Drawing.Size(232, 20);
            this.cboMovieSchedule.StyleController = this.layoutForm;
            this.cboMovieSchedule.TabIndex = 10;
            this.cboMovieSchedule.EditValueChanged += new System.EventHandler(this.cboMovieSchedule_EditValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(30, 709);
            this.dtpDate.MenuManager = this.barManager1;
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.BeepOnError = true;
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dtpDate.Properties.MaskSettings.Set("mask", "d");
            this.dtpDate.Properties.MinValue = new System.DateTime(2024, 11, 8, 2, 25, 47, 0);
            this.dtpDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDate.Properties.UseMaskAsDisplayFormat = true;
            this.dtpDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDate.Size = new System.Drawing.Size(232, 20);
            this.dtpDate.StyleController = this.layoutForm;
            this.dtpDate.TabIndex = 14;
            this.dtpDate.EditValueChanged += new System.EventHandler(this.dtpDate_EditValueChanged);
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Location = new System.Drawing.Point(30, 161);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Properties.DisplayFormat.FormatString = "d";
            this.txtTenPhim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenPhim.Properties.EditFormat.FormatString = "d";
            this.txtTenPhim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTenPhim.Size = new System.Drawing.Size(480, 20);
            this.txtTenPhim.StyleController = this.layoutForm;
            this.txtTenPhim.TabIndex = 12;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Enabled = false;
            this.txtMaPhim.Location = new System.Drawing.Point(30, 109);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Properties.DisplayFormat.FormatString = "d";
            this.txtMaPhim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMaPhim.Properties.EditFormat.FormatString = "d";
            this.txtMaPhim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMaPhim.Size = new System.Drawing.Size(480, 20);
            this.txtMaPhim.StyleController = this.layoutForm;
            this.txtMaPhim.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutAction,
            this.layoutControlGroup1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1037, 762);
            this.Root.TextVisible = false;
            // 
            // layoutTitle
            // 
            this.layoutTitle.Control = this.lblTitle;
            this.layoutTitle.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 42);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle.Size = new System.Drawing.Size(1017, 42);
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
            this.layoutTenPhim,
            this.layoutMaPhim,
            this.layoutControlItem5,
            this.layoutThoiLuong});
            this.layoutAction.Location = new System.Drawing.Point(0, 42);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(1017, 149);
            this.layoutAction.Text = "Form Đặt vé";
            // 
            // layoutTenPhim
            // 
            this.layoutTenPhim.Control = this.txtTenPhim;
            this.layoutTenPhim.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutTenPhim.CustomizationFormText = "Đánh giá độ tuổi";
            this.layoutTenPhim.Location = new System.Drawing.Point(0, 52);
            this.layoutTenPhim.Name = "layoutTenPhim";
            this.layoutTenPhim.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutTenPhim.Size = new System.Drawing.Size(496, 52);
            this.layoutTenPhim.Text = "Tên phim:";
            this.layoutTenPhim.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTenPhim.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutMaPhim
            // 
            this.layoutMaPhim.Control = this.txtMaPhim;
            this.layoutMaPhim.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutMaPhim.CustomizationFormText = "Đánh giá độ tuổi";
            this.layoutMaPhim.Location = new System.Drawing.Point(0, 0);
            this.layoutMaPhim.Name = "layoutMaPhim";
            this.layoutMaPhim.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutMaPhim.Size = new System.Drawing.Size(496, 52);
            this.layoutMaPhim.Text = "Mã phim:";
            this.layoutMaPhim.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutMaPhim.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAgeRating;
            this.layoutControlItem5.Location = new System.Drawing.Point(496, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem5.Size = new System.Drawing.Size(497, 52);
            this.layoutControlItem5.Text = "Kiểm duyệt:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutThoiLuong
            // 
            this.layoutThoiLuong.Control = this.txtThoiLuong;
            this.layoutThoiLuong.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutThoiLuong.CustomizationFormText = "Đánh giá độ tuổi";
            this.layoutThoiLuong.Location = new System.Drawing.Point(496, 52);
            this.layoutThoiLuong.Name = "layoutThoiLuong";
            this.layoutThoiLuong.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutThoiLuong.Size = new System.Drawing.Size(497, 52);
            this.layoutThoiLuong.Text = "Thời lượng:";
            this.layoutThoiLuong.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutThoiLuong.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 663);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1017, 79);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtpDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem4.Size = new System.Drawing.Size(248, 55);
            this.layoutControlItem4.Text = "Ngày chiếu:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboMovieSchedule;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Chọn ngày:";
            this.layoutControlItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem3.ImageOptions.Image")));
            this.layoutControlItem3.Location = new System.Drawing.Point(248, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(248, 55);
            this.layoutControlItem3.Text = "Suất chiếu:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnTiepTuc;
            this.layoutControlItem7.Location = new System.Drawing.Point(744, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsToolTip.ToolTip = "Tiếp tục chọn Ghế";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem7.Size = new System.Drawing.Size(249, 55);
            this.layoutControlItem7.Text = " ";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(496, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(248, 55);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgvMovies;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1017, 472);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ActionBar
            // 
            this.ActionBar.BarName = "Main menu";
            this.ActionBar.DockCol = 0;
            this.ActionBar.DockRow = 0;
            this.ActionBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ActionBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.MultiLine = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
            // 
            // ucChonPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucChonPhim";
            this.Size = new System.Drawing.Size(1037, 786);
            this.Load += new System.EventHandler(this.ucChonPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeRating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMovieSchedule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThoiLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem btnThucThi;
        private DevExpress.XtraBars.BarButtonItem btnTaoBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtThoiLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutThoiLuong;
        private DevExpress.XtraBars.Bar ActionBar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.TextEdit txtAgeRating;
        private DevExpress.XtraEditors.LookUpEdit cboMovieSchedule;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnTiepTuc;
        private DevExpress.XtraEditors.TextEdit txtTenPhim;
        private DevExpress.XtraLayout.LayoutControlItem layoutTenPhim;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtMaPhim;
        private DevExpress.XtraLayout.LayoutControlItem layoutMaPhim;
        private DevExpress.XtraGrid.GridControl dgvMovies;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
