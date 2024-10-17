namespace GUI.UI.Modules
{
    partial class ucGhe
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
            this.dgvSeats = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCouples = new System.Windows.Forms.ComboBox();
            this.cboCols = new System.Windows.Forms.ComboBox();
            this.cboTheater = new System.Windows.Forms.ComboBox();
            this.cboRows = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
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
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm Mới";
            this.btnLamMoi.Hint = "Làm mới dữ liệu";
            this.btnLamMoi.Id = 3;
            this.btnLamMoi.ImageOptions.Image = global::GUI.Properties.Resources.refreshpivottable_16x16;
            this.btnLamMoi.ImageOptions.LargeImage = global::GUI.Properties.Resources.refreshpivottable_32x32;
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1002, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1002, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1002, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 605);
            // 
            // dgvSeats
            // 
            this.dgvSeats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSeats.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSeats.Location = new System.Drawing.Point(0, 208);
            this.dgvSeats.MainView = this.gridView1;
            this.dgvSeats.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSeats.Name = "dgvSeats";
            this.dgvSeats.Size = new System.Drawing.Size(1002, 427);
            this.dgvSeats.TabIndex = 16;
            this.dgvSeats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvSeats;
            this.gridView1.Name = "gridView1";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1002, 45);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số lượng dãy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng ghế mỗi dãy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Số lượng ghế đôi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phòng chiếu:";
            // 
            // cboCouples
            // 
            this.cboCouples.FormattingEnabled = true;
            this.cboCouples.Location = new System.Drawing.Point(139, 125);
            this.cboCouples.Name = "cboCouples";
            this.cboCouples.Size = new System.Drawing.Size(121, 24);
            this.cboCouples.TabIndex = 23;
            // 
            // cboCols
            // 
            this.cboCols.FormattingEnabled = true;
            this.cboCols.Location = new System.Drawing.Point(573, 127);
            this.cboCols.Name = "cboCols";
            this.cboCols.Size = new System.Drawing.Size(121, 24);
            this.cboCols.TabIndex = 23;
            // 
            // cboTheater
            // 
            this.cboTheater.FormattingEnabled = true;
            this.cboTheater.Location = new System.Drawing.Point(139, 95);
            this.cboTheater.Name = "cboTheater";
            this.cboTheater.Size = new System.Drawing.Size(121, 24);
            this.cboTheater.TabIndex = 23;
            // 
            // cboRows
            // 
            this.cboRows.FormattingEnabled = true;
            this.cboRows.Location = new System.Drawing.Point(573, 97);
            this.cboRows.Name = "cboRows";
            this.cboRows.Size = new System.Drawing.Size(121, 24);
            this.cboRows.TabIndex = 24;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 120);
            // 
            // ucGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboRows);
            this.Controls.Add(this.cboTheater);
            this.Controls.Add(this.cboCols);
            this.Controls.Add(this.cboCouples);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucGhe";
            this.Size = new System.Drawing.Size(1002, 635);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgvSeats;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboRows;
        private System.Windows.Forms.ComboBox cboTheater;
        private System.Windows.Forms.ComboBox cboCols;
        private System.Windows.Forms.ComboBox cboCouples;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
    }
}
