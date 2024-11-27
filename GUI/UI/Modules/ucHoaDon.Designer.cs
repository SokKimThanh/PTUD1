namespace GUI.UI.Modules
{
    partial class ucHoaDon
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
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.grdData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
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
            this.btnThem,
            this.btnXoa,
            this.btnCapNhat,
            this.btnLamMoi,
            this.barButtonItem1,
            this.btnIn});
            this.barManager1.MainMenu = this.ActionBar;
            this.barManager1.MaxItemId = 6;
            // 
            // ActionBar
            // 
            this.ActionBar.BarName = "Main menu";
            this.ActionBar.DockCol = 0;
            this.ActionBar.DockRow = 0;
            this.ActionBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ActionBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.MultiLine = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
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
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Hint = "In hóa đơn";
            this.btnIn.Id = 5;
            this.btnIn.ImageOptions.Image = global::GUI.Properties.Resources.printer_16x161;
            this.btnIn.ImageOptions.LargeImage = global::GUI.Properties.Resources.printer_32x321;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1156, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 761);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1156, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 731);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1156, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 731);
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Hint = "Xóa dữ liệu";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = global::GUI.Properties.Resources.deletelist_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::GUI.Properties.Resources.deletelist_32x32;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Hint = "Cập nhật dữ liệu";
            this.btnCapNhat.Id = 2;
            this.btnCapNhat.ImageOptions.Image = global::GUI.Properties.Resources.edit_16x161;
            this.btnCapNhat.ImageOptions.LargeImage = global::GUI.Properties.Resources.edit_32x321;
            this.btnCapNhat.Name = "btnCapNhat";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In hóa đơn";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = global::GUI.Properties.Resources.printernetwork_16x161;
            this.barButtonItem1.ImageOptions.LargeImage = global::GUI.Properties.Resources.printernetwork_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgv);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 30);
            this.layoutForm.Margin = new System.Windows.Forms.Padding(4);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(25, 428, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(1156, 731);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1116, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgv
            // 
            this.dgv.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.Location = new System.Drawing.Point(24, 94);
            this.dgv.MainView = this.grdData;
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1108, 613);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdData});
            // 
            // grdData
            // 
            this.grdData.DetailHeight = 431;
            this.grdData.GridControl = this.dgv;
            this.grdData.Name = "grdData";
            this.grdData.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdData_RowClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutDGV});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1156, 731);
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
            this.layoutTitle.Size = new System.Drawing.Size(1136, 44);
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutTitle.Text = "Title";
            this.layoutTitle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTitle.TextVisible = false;
            // 
            // layoutDGV
            // 
            this.layoutDGV.CaptionImageOptions.Image = global::GUI.Properties.Resources.newtablestyle_16x16;
            this.layoutDGV.CustomizationFormText = "Danh sách dữ liệu";
            this.layoutDGV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutDGV.Location = new System.Drawing.Point(0, 44);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(1136, 667);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1112, 617);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(1156, 761);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView grdData;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnIn;
    }
}
