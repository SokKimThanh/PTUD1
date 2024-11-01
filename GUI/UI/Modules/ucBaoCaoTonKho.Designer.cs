namespace GUI.UI.Modules
{
    partial class ucBaoCaoTonKho
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
            this.btnThucThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuPDF = new DevExpress.XtraBars.BarButtonItem();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rptViewReport = new DevExpress.XtraEditors.RadioGroup();
            this.txtStartDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtEndDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGV = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptViewReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btnThucThi,
            this.btnTaoBaoCao,
            this.btnCapNhat,
            this.btnLamMoi,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnLuuPDF});
            this.barManager1.MainMenu = this.ActionBar;
            this.barManager1.MaxItemId = 10;
            // 
            // ActionBar
            // 
            this.ActionBar.BarName = "Main menu";
            this.ActionBar.DockCol = 0;
            this.ActionBar.DockRow = 0;
            this.ActionBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ActionBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThucThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoBaoCao, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.MultiLine = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
            // 
            // btnThucThi
            // 
            this.btnThucThi.Caption = "Thực thi";
            this.btnThucThi.Hint = "Hiển thị kết quả";
            this.btnThucThi.Id = 0;
            this.btnThucThi.ImageOptions.Image = global::GUI.Properties.Resources.play_16x16;
            this.btnThucThi.ImageOptions.LargeImage = global::GUI.Properties.Resources.play_32x32;
            this.btnThucThi.Name = "btnThucThi";
            this.btnThucThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThucThi_ItemClick);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Caption = "Tạo báo cáo";
            this.btnTaoBaoCao.Hint = "Xóa dữ liệu";
            this.btnTaoBaoCao.Id = 1;
            this.btnTaoBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.boreport2_16x161;
            this.btnTaoBaoCao.ImageOptions.LargeImage = global::GUI.Properties.Resources.boreport2_32x321;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoBaoCao_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(731, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 610);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(731, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 586);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(731, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 586);
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
            this.barButtonItem1.Caption = "Tạo báo cáo";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lưu PDF";
            this.barButtonItem2.Hint = "Lưu báo cáo thành file PDF";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = global::GUI.Properties.Resources.printviapdf_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::GUI.Properties.Resources.printviapdf_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu PDF";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = global::GUI.Properties.Resources.exporttopdf_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::GUI.Properties.Resources.exporttopdf_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.Image = global::GUI.Properties.Resources.exporttopdf_16x161;
            this.barButtonItem4.ImageOptions.LargeImage = global::GUI.Properties.Resources.exporttopdf_32x321;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnLuuPDF
            // 
            this.btnLuuPDF.Id = 9;
            this.btnLuuPDF.Name = "btnLuuPDF";
            // 
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.dgv);
            this.layoutForm.Controls.Add(this.rptViewReport);
            this.layoutForm.Controls.Add(this.txtStartDate);
            this.layoutForm.Controls.Add(this.txtEndDate);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 24);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1064, 288, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(731, 586);
            this.layoutForm.TabIndex = 15;
            this.layoutForm.Text = "layoutControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(695, 20);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(24, 180);
            this.dgv.MainView = this.gridView1;
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(683, 382);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv;
            this.gridView1.Name = "gridView1";
            // 
            // rptViewReport
            // 
            this.rptViewReport.Location = new System.Drawing.Point(367, 97);
            this.rptViewReport.Name = "rptViewReport";
            this.rptViewReport.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rptViewReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Tổng quan", true, null, "rptTongQuan"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Chi Tiết", true, null, "rptChiTiet")});
            this.rptViewReport.Size = new System.Drawing.Size(340, 34);
            this.rptViewReport.StyleController = this.layoutForm;
            this.rptViewReport.TabIndex = 11;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(137, 81);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.BeepOnError = true;
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.DisplayFormat.FormatString = "d";
            this.txtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.EditFormat.FormatString = "d";
            this.txtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng",
            "Quá tải"});
            this.txtStartDate.Properties.Sorted = true;
            this.txtStartDate.Size = new System.Drawing.Size(226, 20);
            this.txtStartDate.StyleController = this.layoutForm;
            this.txtStartDate.TabIndex = 10;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(137, 105);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.BeepOnError = true;
            this.txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.DisplayFormat.FormatString = "d";
            this.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.EditFormat.FormatString = "d";
            this.txtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.Items.AddRange(new object[] {
            "Bán chậm",
            "Bán nhanh",
            "Ổn định"});
            this.txtEndDate.Properties.Sorted = true;
            this.txtEndDate.Size = new System.Drawing.Size(226, 20);
            this.txtEndDate.StyleController = this.layoutForm;
            this.txtEndDate.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutDGV,
            this.layoutAction});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(731, 586);
            this.Root.TextVisible = false;
            // 
            // layoutTitle
            // 
            this.layoutTitle.Control = this.lblTitle;
            this.layoutTitle.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle.MinSize = new System.Drawing.Size(36, 1);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle.Size = new System.Drawing.Size(711, 36);
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
            this.layoutDGV.Location = new System.Drawing.Point(0, 135);
            this.layoutDGV.Name = "layoutDGV";
            this.layoutDGV.Size = new System.Drawing.Size(711, 431);
            this.layoutDGV.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv;
            this.layoutControlItem1.CustomizationFormText = "dgvCaLamViec";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(687, 386);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutAction
            // 
            this.layoutAction.CustomizationFormText = "Thao tác nhập liệu";
            this.layoutAction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutAction.Location = new System.Drawing.Point(0, 36);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.OptionsItemText.TextToControlDistance = 3;
            this.layoutAction.Size = new System.Drawing.Size(711, 99);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtStartDate;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Từ ngày:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(343, 24);
            this.layoutControlItem2.Text = "Trạng thái kho:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rptViewReport;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Hiển thị:";
            this.layoutControlItem4.Location = new System.Drawing.Point(343, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(344, 54);
            this.layoutControlItem4.Text = "Hiển thị:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEndDate;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Đến ngày:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(343, 30);
            this.layoutControlItem3.Text = "Trạng thái mặt hàng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(101, 13);
            // 
            // ucBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucBaoCaoTonKho";
            this.Size = new System.Drawing.Size(731, 610);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptViewReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar ActionBar;
        private DevExpress.XtraBars.BarButtonItem btnThucThi;
        private DevExpress.XtraBars.BarButtonItem btnTaoBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnLuuPDF;
        private DevExpress.XtraLayout.LayoutControl layoutForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDGV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.RadioGroup rptViewReport;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit txtStartDate;
        private DevExpress.XtraEditors.ComboBoxEdit txtEndDate;
    }
}
