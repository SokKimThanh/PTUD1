namespace GUI.UI.Modules
{
    partial class ucPhongChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhongChieu));
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
            this.dgvView = new DevExpress.XtraGrid.GridControl();
            this.gvTheaters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboRows = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboColumns = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboCouples = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutFieldTenPhongChieu = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutFieldSoGheDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutFieldGheDoi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutFieldTrangThaiPhong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutFieldSoDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTitle = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheaters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCouples.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldTenPhongChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldSoGheDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldGheDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldTrangThaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldSoDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(744, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 499);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(744, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.dgvView);
            this.layoutForm.Controls.Add(this.txtName);
            this.layoutForm.Controls.Add(this.cboStatus);
            this.layoutForm.Controls.Add(this.cboRows);
            this.layoutForm.Controls.Add(this.cboColumns);
            this.layoutForm.Controls.Add(this.cboCouples);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 24);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1064, 288, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(744, 475);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // dgvView
            // 
            this.dgvView.Location = new System.Drawing.Point(22, 176);
            this.dgvView.MainView = this.gvTheaters;
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(700, 279);
            this.dgvView.TabIndex = 8;
            this.dgvView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTheaters});
            // 
            // gvTheaters
            // 
            this.gvTheaters.GridControl = this.dgvView;
            this.gvTheaters.Name = "gvTheaters";
            this.gvTheaters.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTheaters.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTheaters.OptionsBehavior.Editable = false;
            this.gvTheaters.OptionsView.ShowIndicator = false;
            this.gvTheaters.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvTheaters_RowCellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.StyleController = this.layoutForm;
            this.txtName.TabIndex = 5;
            // 
            // cboExpenseStatus
            // 
            this.cboStatus.EditValue = "";
            this.cboStatus.Location = new System.Drawing.Point(169, 105);
            this.cboStatus.Name = "cboExpenseStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.DropDownRows = 2;
            this.cboStatus.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(125, 20);
            this.cboStatus.StyleController = this.layoutForm;
            this.cboStatus.TabIndex = 7;
            // 
            // cboRows
            // 
            this.cboRows.EditValue = "";
            this.cboRows.Location = new System.Drawing.Point(310, 105);
            this.cboRows.Name = "cboRows";
            this.cboRows.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRows.Properties.DropDownRows = 5;
            this.cboRows.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboRows.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRows.Size = new System.Drawing.Size(125, 20);
            this.cboRows.StyleController = this.layoutForm;
            this.cboRows.TabIndex = 7;
            // 
            // cboColumns
            // 
            this.cboColumns.EditValue = "";
            this.cboColumns.Location = new System.Drawing.Point(451, 105);
            this.cboColumns.Name = "cboColumns";
            this.cboColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboColumns.Properties.DropDownRows = 5;
            this.cboColumns.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboColumns.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboColumns.Size = new System.Drawing.Size(124, 20);
            this.cboColumns.StyleController = this.layoutForm;
            this.cboColumns.TabIndex = 7;
            // 
            // cboCouples
            // 
            this.cboCouples.EditValue = "";
            this.cboCouples.Location = new System.Drawing.Point(591, 105);
            this.cboCouples.Name = "cboCouples";
            this.cboCouples.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCouples.Properties.DropDownRows = 3;
            this.cboCouples.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboCouples.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCouples.Size = new System.Drawing.Size(125, 20);
            this.cboCouples.StyleController = this.layoutForm;
            this.cboCouples.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutAction,
            this.layoutDGV,
            this.lblTitle});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(744, 475);
            this.Root.TextVisible = false;
            // 
            // layoutAction
            // 
            this.layoutAction.CaptionImageOptions.Image = global::GUI.Properties.Resources.reviewallowuserstoeditranges_16x16;
            this.layoutAction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutFieldTenPhongChieu,
            this.layoutFieldSoGheDay,
            this.layoutFieldGheDoi,
            this.layoutFieldTrangThaiPhong,
            this.layoutFieldSoDay});
            this.layoutAction.Location = new System.Drawing.Point(0, 39);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(726, 96);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutFieldTenPhongChieu
            // 
            this.layoutFieldTenPhongChieu.Control = this.txtName;
            this.layoutFieldTenPhongChieu.CustomizationFormText = "Tên phòng chiếu:";
            this.layoutFieldTenPhongChieu.ImageOptions.Image = global::GUI.Properties.Resources.changetextcase_16x16;
            this.layoutFieldTenPhongChieu.Location = new System.Drawing.Point(0, 0);
            this.layoutFieldTenPhongChieu.Name = "layoutFieldTenPhongChieu";
            this.layoutFieldTenPhongChieu.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutFieldTenPhongChieu.Size = new System.Drawing.Size(141, 55);
            this.layoutFieldTenPhongChieu.Text = "Tên phòng chiếu:";
            this.layoutFieldTenPhongChieu.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutFieldTenPhongChieu.TextSize = new System.Drawing.Size(107, 16);
            // 
            // layoutFieldSoGheDay
            // 
            this.layoutFieldSoGheDay.Control = this.cboColumns;
            this.layoutFieldSoGheDay.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutFieldSoGheDay.CustomizationFormText = "Trạng thái phòng:";
            this.layoutFieldSoGheDay.ImageOptions.Image = global::GUI.Properties.Resources.greenwhite_16x16;
            this.layoutFieldSoGheDay.Location = new System.Drawing.Point(423, 0);
            this.layoutFieldSoGheDay.Name = "layoutFieldSoGheDay";
            this.layoutFieldSoGheDay.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutFieldSoGheDay.Size = new System.Drawing.Size(140, 55);
            this.layoutFieldSoGheDay.Text = "Số ghế/dãy: ";
            this.layoutFieldSoGheDay.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutFieldSoGheDay.TextSize = new System.Drawing.Size(107, 16);
            // 
            // layoutFieldGheDoi
            // 
            this.layoutFieldGheDoi.Control = this.cboCouples;
            this.layoutFieldGheDoi.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutFieldGheDoi.CustomizationFormText = "Trạng thái phòng:";
            this.layoutFieldGheDoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem6.ImageOptions.Image")));
            this.layoutFieldGheDoi.Location = new System.Drawing.Point(563, 0);
            this.layoutFieldGheDoi.Name = "layoutFieldGheDoi";
            this.layoutFieldGheDoi.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutFieldGheDoi.Size = new System.Drawing.Size(141, 55);
            this.layoutFieldGheDoi.Text = "Ghế đôi:";
            this.layoutFieldGheDoi.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutFieldGheDoi.TextSize = new System.Drawing.Size(107, 16);
            // 
            // layoutFieldTrangThaiPhong
            // 
            this.layoutFieldTrangThaiPhong.Control = this.cboStatus;
            this.layoutFieldTrangThaiPhong.CustomizationFormText = "Trạng thái phòng:";
            this.layoutFieldTrangThaiPhong.ImageOptions.Image = global::GUI.Properties.Resources.status_16x16;
            this.layoutFieldTrangThaiPhong.Location = new System.Drawing.Point(141, 0);
            this.layoutFieldTrangThaiPhong.Name = "layoutFieldTrangThaiPhong";
            this.layoutFieldTrangThaiPhong.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutFieldTrangThaiPhong.Size = new System.Drawing.Size(141, 55);
            this.layoutFieldTrangThaiPhong.Text = "Trạng thái phòng:";
            this.layoutFieldTrangThaiPhong.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutFieldTrangThaiPhong.TextSize = new System.Drawing.Size(107, 16);
            // 
            // layoutFieldSoDay
            // 
            this.layoutFieldSoDay.Control = this.cboRows;
            this.layoutFieldSoDay.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutFieldSoDay.CustomizationFormText = "Trạng thái phòng:";
            this.layoutFieldSoDay.ImageOptions.Image = global::GUI.Properties.Resources.rowindex_16x16;
            this.layoutFieldSoDay.Location = new System.Drawing.Point(282, 0);
            this.layoutFieldSoDay.Name = "layoutFieldSoDay";
            this.layoutFieldSoDay.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutFieldSoDay.Size = new System.Drawing.Size(141, 55);
            this.layoutFieldSoDay.Text = "Số dãy:";
            this.layoutFieldSoDay.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutFieldSoDay.TextSize = new System.Drawing.Size(107, 16);
            // 
            // layoutDGV
            // 
            this.layoutDGV.CaptionImageOptions.Image = global::GUI.Properties.Resources.newtablestyle_16x16;
            this.layoutDGV.CustomizationFormText = "Danh sách dữ liệu";
            this.layoutDGV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutDGV.Location = new System.Drawing.Point(0, 135);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(726, 324);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgvView;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(704, 283);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowHotTrack = false;
            this.lblTitle.AppearanceItemCaption.BorderColor = System.Drawing.Color.Silver;
            this.lblTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblTitle.AppearanceItemCaption.Options.UseBorderColor = true;
            this.lblTitle.AppearanceItemCaption.Options.UseFont = true;
            this.lblTitle.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.lblTitle.Size = new System.Drawing.Size(726, 39);
            this.lblTitle.Text = "Title";
            this.lblTitle.TextSize = new System.Drawing.Size(107, 23);
            // 
            // ucPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPhongChieu";
            this.Size = new System.Drawing.Size(744, 499);
            this.Load += new System.EventHandler(this.ucPhongChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheaters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCouples.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldTenPhongChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldSoGheDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldGheDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldTrangThaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutFieldSoDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgvView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTheaters;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutFieldTenPhongChieu;
        private DevExpress.XtraLayout.LayoutControlItem layoutFieldTrangThaiPhong;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cboRows;
        private DevExpress.XtraEditors.ComboBoxEdit cboColumns;
        private DevExpress.XtraEditors.ComboBoxEdit cboCouples;
        private DevExpress.XtraLayout.LayoutControlItem layoutFieldSoDay;
        private DevExpress.XtraLayout.LayoutControlItem layoutFieldSoGheDay;
        private DevExpress.XtraLayout.LayoutControlItem layoutFieldGheDoi;
        private DevExpress.XtraLayout.SimpleLabelItem lblTitle;
    }
}
