namespace GUI.UI.Modules
{
    partial class ucChiPhi
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
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboExpenseStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.cboExpenseType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReason = new DevExpress.XtraEditors.TextEdit();
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
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutNhapDuLieu = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutReason = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutExpenseType = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpenseStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpenseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhapDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutExpenseType)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgv);
            this.layoutForm.Controls.Add(this.cboExpenseStatus);
            this.layoutForm.Controls.Add(this.cboExpenseType);
            this.layoutForm.Controls.Add(this.txtReason);
            this.layoutForm.Controls.Add(this.txtPrice);
            this.layoutForm.Controls.Add(this.txtQuantity);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 24);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1064, 288, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(881, 588);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(845, 20);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(24, 198);
            this.dgv.MainView = this.gridView1;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(833, 366);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            // 
            // cboExpenseStatus
            // 
            this.cboExpenseStatus.Location = new System.Drawing.Point(557, 129);
            this.cboExpenseStatus.Name = "cboExpenseStatus";
            this.cboExpenseStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboExpenseStatus.Properties.NullText = "";
            this.cboExpenseStatus.Size = new System.Drawing.Size(300, 20);
            this.cboExpenseStatus.StyleController = this.layoutForm;
            this.cboExpenseStatus.TabIndex = 10;
            this.cboExpenseStatus.EditValueChanged += new System.EventHandler(this.cboStatus_EditValueChanged);
            // 
            // cboExpenseType
            // 
            this.cboExpenseType.Location = new System.Drawing.Point(139, 81);
            this.cboExpenseType.Name = "cboExpenseType";
            this.cboExpenseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboExpenseType.Properties.NullText = "";
            this.cboExpenseType.Size = new System.Drawing.Size(718, 20);
            this.cboExpenseType.StyleController = this.layoutForm;
            this.cboExpenseType.TabIndex = 10;
            this.cboExpenseType.EditValueChanged += new System.EventHandler(this.cboExpenseType_EditValueChanged);
            // 
            // txtReason
            // 
            this.txtReason.EditValue = "";
            this.txtReason.Location = new System.Drawing.Point(139, 129);
            this.txtReason.MenuManager = this.barManager1;
            this.txtReason.Name = "txtReason";
            this.txtReason.Properties.NullText = "[EditValue is null]";
            this.txtReason.Size = new System.Drawing.Size(299, 20);
            this.txtReason.StyleController = this.layoutForm;
            this.txtReason.TabIndex = 10;
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
            this.barDockControlTop.Size = new System.Drawing.Size(881, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 588);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 588);
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = "0";
            this.txtPrice.Location = new System.Drawing.Point(557, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.BeepOnError = true;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("mask", "c0");
            this.txtPrice.Properties.NullText = "[EditValue is null]";
            this.txtPrice.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrice.Size = new System.Drawing.Size(300, 20);
            this.txtPrice.StyleController = this.layoutForm;
            this.txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = "0";
            this.txtQuantity.Location = new System.Drawing.Point(139, 105);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.BeepOnError = true;
            this.txtQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtQuantity.Properties.MaskSettings.Set("mask", "d");
            this.txtQuantity.Properties.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Size = new System.Drawing.Size(299, 20);
            this.txtQuantity.StyleController = this.layoutForm;
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutDGV,
            this.layoutNhapDuLieu});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(881, 588);
            this.Root.TextVisible = false;
            // 
            // layoutTitle
            // 
            this.layoutTitle.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutTitle.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutTitle.Control = this.lblTitle;
            this.layoutTitle.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 36);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 36);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle.Size = new System.Drawing.Size(861, 36);
            this.layoutTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
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
            this.layoutDGV.Location = new System.Drawing.Point(0, 153);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(861, 415);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(837, 370);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutNhapDuLieu
            // 
            this.layoutNhapDuLieu.CaptionImageOptions.Image = global::GUI.Properties.Resources.boreport2_16x161;
            this.layoutNhapDuLieu.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutPrice,
            this.layoutQuantity,
            this.layoutStatus,
            this.layoutReason,
            this.layoutExpenseType});
            this.layoutNhapDuLieu.Location = new System.Drawing.Point(0, 36);
            this.layoutNhapDuLieu.Name = "layoutNhapDuLieu";
            this.layoutNhapDuLieu.Size = new System.Drawing.Size(861, 117);
            this.layoutNhapDuLieu.Text = "Thao tác nhập dữ liệu";
            // 
            // layoutPrice
            // 
            this.layoutPrice.Control = this.txtPrice;
            this.layoutPrice.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutPrice.CustomizationFormText = "layoutControlItem2";
            this.layoutPrice.Location = new System.Drawing.Point(418, 24);
            this.layoutPrice.Name = "layoutPrice";
            this.layoutPrice.Size = new System.Drawing.Size(419, 24);
            this.layoutPrice.Text = "Tổng tiền nhập hàng:";
            this.layoutPrice.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutQuantity
            // 
            this.layoutQuantity.Control = this.txtQuantity;
            this.layoutQuantity.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutQuantity.CustomizationFormText = "layoutControlItem2";
            this.layoutQuantity.Location = new System.Drawing.Point(0, 24);
            this.layoutQuantity.Name = "layoutQuantity";
            this.layoutQuantity.Size = new System.Drawing.Size(418, 24);
            this.layoutQuantity.Text = "Số lượng nhập hàng:";
            this.layoutQuantity.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutStatus
            // 
            this.layoutStatus.Control = this.cboExpenseStatus;
            this.layoutStatus.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutStatus.CustomizationFormText = "layoutControlItem2";
            this.layoutStatus.Location = new System.Drawing.Point(418, 48);
            this.layoutStatus.Name = "layoutStatus";
            this.layoutStatus.Size = new System.Drawing.Size(419, 24);
            this.layoutStatus.Text = "Trạng thái:";
            this.layoutStatus.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutReason
            // 
            this.layoutReason.Control = this.txtReason;
            this.layoutReason.Location = new System.Drawing.Point(0, 48);
            this.layoutReason.Name = "layoutReason";
            this.layoutReason.Size = new System.Drawing.Size(418, 24);
            this.layoutReason.Text = "Lý do:";
            this.layoutReason.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutExpenseType
            // 
            this.layoutExpenseType.Control = this.cboExpenseType;
            this.layoutExpenseType.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutExpenseType.CustomizationFormText = "layoutControlItem2";
            this.layoutExpenseType.Location = new System.Drawing.Point(0, 0);
            this.layoutExpenseType.Name = "layoutExpenseType";
            this.layoutExpenseType.Size = new System.Drawing.Size(837, 24);
            this.layoutExpenseType.Text = "Loại chi phí:";
            this.layoutExpenseType.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ucChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucChiPhi";
            this.Size = new System.Drawing.Size(881, 612);
            this.Load += new System.EventHandler(this.ucChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpenseStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExpenseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhapDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutExpenseType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutNhapDuLieu;
        private DevExpress.XtraLayout.LayoutControlItem layoutReason;
        private DevExpress.XtraEditors.LookUpEdit cboExpenseStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutStatus;
        private DevExpress.XtraEditors.LookUpEdit cboExpenseType;
        private DevExpress.XtraEditors.TextEdit txtReason;
        private DevExpress.XtraLayout.LayoutControlItem layoutQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutExpenseType;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutPrice;
    }
}
