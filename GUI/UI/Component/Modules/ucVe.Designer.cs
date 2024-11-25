namespace GUI.UI.Modules
{
    partial class ucVe
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
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTickets = new DevExpress.XtraGrid.GridControl();
            this.gvTickets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMovieScheduleDate = new DevExpress.XtraEditors.TextEdit();
            this.txtTheaterName = new DevExpress.XtraEditors.TextEdit();
            this.txtSeatName = new DevExpress.XtraEditors.TextEdit();
            this.txtMovieName = new DevExpress.XtraEditors.TextEdit();
            this.txtTicketID = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.TextEdit();
            this.cboStatusTicket = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieScheduleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheaterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.btnXoa,
            this.btnIn,
            this.btnLamMoi});
            this.barManager1.MainMenu = this.ActionBar;
            this.barManager1.MaxItemId = 4;
            // 
            // ActionBar
            // 
            this.ActionBar.BarName = "Main menu";
            this.ActionBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.ActionBar.DockCol = 0;
            this.ActionBar.DockRow = 0;
            this.ActionBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ActionBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.AllowQuickCustomization = false;
            this.ActionBar.OptionsBar.DisableClose = true;
            this.ActionBar.OptionsBar.DisableCustomization = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
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
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Hint = "Cập nhật dữ liệu";
            this.btnIn.Id = 2;
            this.btnIn.ImageOptions.Image = global::GUI.Properties.Resources.printer_16x16;
            this.btnIn.ImageOptions.LargeImage = global::GUI.Properties.Resources.edit_32x321;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(799, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 578);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(799, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 548);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(799, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 548);
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
            // btnThem
            // 
            this.btnThem.Caption = "Thêm mới";
            this.btnThem.Hint = "Thêm mới";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::GUI.Properties.Resources.insert_16x16;
            this.btnThem.ImageOptions.LargeImage = global::GUI.Properties.Resources.insert_32x32;
            this.btnThem.Name = "btnThem";
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgvTickets);
            this.layoutForm.Controls.Add(this.txtMovieScheduleDate);
            this.layoutForm.Controls.Add(this.txtTheaterName);
            this.layoutForm.Controls.Add(this.txtSeatName);
            this.layoutForm.Controls.Add(this.txtMovieName);
            this.layoutForm.Controls.Add(this.txtTicketID);
            this.layoutForm.Controls.Add(this.txtCreateDate);
            this.layoutForm.Controls.Add(this.cboStatusTicket);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 30);
            this.layoutForm.Margin = new System.Windows.Forms.Padding(4);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 288, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(799, 548);
            this.layoutForm.TabIndex = 10;
            this.layoutForm.Text = "layoutControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(759, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgvTickets
            // 
            this.dgvTickets.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgvTickets.Location = new System.Drawing.Point(24, 252);
            this.dgvTickets.MainView = this.gvTickets;
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(751, 272);
            this.dgvTickets.TabIndex = 8;
            this.dgvTickets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTickets});
            this.dgvTickets.Click += new System.EventHandler(this.dgvTickets_Click);
            // 
            // gvTickets
            // 
            this.gvTickets.DetailHeight = 431;
            this.gvTickets.GridControl = this.dgvTickets;
            this.gvTickets.Name = "gvTickets";
            this.gvTickets.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTickets.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTickets.OptionsBehavior.Editable = false;
            this.gvTickets.OptionsCustomization.AllowColumnMoving = false;
            this.gvTickets.OptionsCustomization.AllowColumnResizing = false;
            this.gvTickets.OptionsCustomization.AllowGroup = false;
            this.gvTickets.OptionsFind.AlwaysVisible = true;
            this.gvTickets.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvTickets.OptionsView.ShowDetailButtons = false;
            this.gvTickets.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvTickets.OptionsView.ShowGroupPanel = false;
            // 
            // txtMovieScheduleDate
            // 
            this.txtMovieScheduleDate.Enabled = false;
            this.txtMovieScheduleDate.Location = new System.Drawing.Point(487, 146);
            this.txtMovieScheduleDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieScheduleDate.MenuManager = this.barManager1;
            this.txtMovieScheduleDate.Name = "txtMovieScheduleDate";
            this.txtMovieScheduleDate.Size = new System.Drawing.Size(288, 22);
            this.txtMovieScheduleDate.StyleController = this.layoutForm;
            this.txtMovieScheduleDate.TabIndex = 10;
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.Enabled = false;
            this.txtTheaterName.Location = new System.Drawing.Point(110, 146);
            this.txtTheaterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.Size = new System.Drawing.Size(287, 22);
            this.txtTheaterName.StyleController = this.layoutForm;
            this.txtTheaterName.TabIndex = 10;
            // 
            // txtSeatName
            // 
            this.txtSeatName.Enabled = false;
            this.txtSeatName.Location = new System.Drawing.Point(110, 120);
            this.txtSeatName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeatName.Name = "txtSeatName";
            this.txtSeatName.Size = new System.Drawing.Size(287, 22);
            this.txtSeatName.StyleController = this.layoutForm;
            this.txtSeatName.TabIndex = 10;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Enabled = false;
            this.txtMovieName.Location = new System.Drawing.Point(487, 120);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(288, 22);
            this.txtMovieName.StyleController = this.layoutForm;
            this.txtMovieName.TabIndex = 10;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(110, 94);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(287, 22);
            this.txtTicketID.StyleController = this.layoutForm;
            this.txtTicketID.TabIndex = 10;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(487, 94);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(288, 22);
            this.txtCreateDate.StyleController = this.layoutForm;
            this.txtCreateDate.TabIndex = 10;
            // 
            // cboStatusTicket
            // 
            this.cboStatusTicket.Location = new System.Drawing.Point(110, 172);
            this.cboStatusTicket.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatusTicket.Name = "cboStatusTicket";
            this.cboStatusTicket.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusTicket.Properties.Appearance.Options.UseFont = true;
            this.cboStatusTicket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatusTicket.Properties.DropDownRows = 2;
            this.cboStatusTicket.Properties.NullText = "";
            this.cboStatusTicket.Size = new System.Drawing.Size(665, 26);
            this.cboStatusTicket.StyleController = this.layoutForm;
            this.cboStatusTicket.TabIndex = 10;
            this.cboStatusTicket.EditValueChanged += new System.EventHandler(this.cboStatusTicket_EditValueChanged);
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
            this.Root.Size = new System.Drawing.Size(799, 548);
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
            this.layoutTitle.Size = new System.Drawing.Size(779, 44);
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
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutAction.Location = new System.Drawing.Point(0, 44);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(779, 158);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cboStatusTicket;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(755, 30);
            this.layoutControlItem7.Text = "Trạng Thái:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtTicketID;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(377, 26);
            this.layoutControlItem8.Text = "Mã vé:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtCreateDate;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem9.Location = new System.Drawing.Point(377, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(378, 26);
            this.layoutControlItem9.Text = "Ngày tạo:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSeatName;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(377, 26);
            this.layoutControlItem6.Text = "Tên ghế:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMovieName;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(377, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(378, 26);
            this.layoutControlItem3.Text = "Tên phim:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTheaterName;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(377, 26);
            this.layoutControlItem4.Text = "Phòng chiếu:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMovieScheduleDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(377, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 26);
            this.layoutControlItem2.Text = "Suất chiếu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutDGV
            // 
            this.layoutDGV.AllowCustomizeChildren = false;
            this.layoutDGV.CaptionImageOptions.Image = global::GUI.Properties.Resources.newtablestyle_16x16;
            this.layoutDGV.CustomizationFormText = "Danh sách dữ liệu";
            this.layoutDGV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutDGV.Location = new System.Drawing.Point(0, 202);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.OptionsCustomization.AllowDrag = DevExpress.XtraLayout.ItemDragDropMode.Disable;
            this.layoutDGV.OptionsCustomization.AllowDrop = DevExpress.XtraLayout.ItemDragDropMode.Disable;
            this.layoutDGV.Size = new System.Drawing.Size(779, 326);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgvTickets;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(755, 276);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucVe";
            this.Size = new System.Drawing.Size(799, 578);
            this.Load += new System.EventHandler(this.ucVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieScheduleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheaterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovieName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTicketID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar ActionBar;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl dgvTickets;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTickets;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit txtMovieScheduleDate;
        private DevExpress.XtraEditors.TextEdit txtTheaterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtSeatName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtMovieName;
        private DevExpress.XtraEditors.TextEdit txtTicketID;
        private DevExpress.XtraEditors.TextEdit txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit cboStatusTicket;
    }
}
