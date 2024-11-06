namespace GUI.UI.Modules
{
    partial class ucChonGhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChonGhe));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.ActionBar = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.layoutForm = new DevExpress.XtraLayout.LayoutControl();
            this.grpSeats = new DevExpress.XtraEditors.GroupControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutAction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).BeginInit();
            this.layoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ActionBar.OptionsBar.MultiLine = true;
            this.ActionBar.OptionsBar.UseWholeRow = true;
            this.ActionBar.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thanh toán";
            this.btnThem.Hint = "Thêm mới";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::GUI.Properties.Resources.insert_16x16;
            this.btnThem.ImageOptions.LargeImage = global::GUI.Properties.Resources.insert_32x32;
            this.btnThem.Name = "btnThem";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Hủy bỏ";
            this.btnXoa.Hint = "Xóa dữ liệu";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = global::GUI.Properties.Resources.deletelist_16x16;
            this.btnXoa.ImageOptions.LargeImage = global::GUI.Properties.Resources.deletelist_32x32;
            this.btnXoa.Name = "btnXoa";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1127, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 980);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1127, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 950);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1127, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 950);
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
            // layoutForm
            // 
            this.layoutForm.Controls.Add(this.groupControl1);
            this.layoutForm.Controls.Add(this.GroupChoosenChair);
            this.layoutForm.Controls.Add(this.lblTitle);
            this.layoutForm.Controls.Add(this.textEdit1);
            this.layoutForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForm.Location = new System.Drawing.Point(0, 30);
            this.layoutForm.Margin = new System.Windows.Forms.Padding(4);
            this.layoutForm.Name = "layoutForm";
            this.layoutForm.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 288, 650, 400);
            this.layoutForm.Root = this.Root;
            this.layoutForm.Size = new System.Drawing.Size(1127, 950);
            this.layoutForm.TabIndex = 9;
            this.layoutForm.Text = "layoutControl1";
            // 
            // grpSeats
            // 
            this.groupControl1.CaptionImageOptions.Image = global::GUI.Properties.Resources.info_16x16;
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Location = new System.Drawing.Point(24, 81);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(918, 190);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Thông Tin phòng chiếu";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 23);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(914, 165);
            this.pictureEdit1.TabIndex = 16;
            // 
            // GroupChoosenChair
            // 
            this.GroupChoosenChair.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.GroupChoosenChair.Appearance.Options.UseBackColor = true;
            this.GroupChoosenChair.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GroupChoosenChair.CaptionImageOptions.Image")));
            this.GroupChoosenChair.Controls.Add(this.pictureEdit7);
            this.GroupChoosenChair.Controls.Add(this.pictureEdit6);
            this.GroupChoosenChair.Controls.Add(this.pictureEdit5);
            this.GroupChoosenChair.Controls.Add(this.pictureEdit4);
            this.GroupChoosenChair.Controls.Add(this.pictureEdit3);
            this.GroupChoosenChair.Controls.Add(this.pictureEdit2);
            this.GroupChoosenChair.Location = new System.Drawing.Point(24, 275);
            this.GroupChoosenChair.Name = "GroupChoosenChair";
            this.GroupChoosenChair.Padding = new System.Windows.Forms.Padding(16);
            this.GroupChoosenChair.Size = new System.Drawing.Size(918, 399);
            this.GroupChoosenChair.TabIndex = 14;
            this.GroupChoosenChair.Text = "Chọn ghế";
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(151, 103);
            this.pictureEdit7.MenuManager = this.barManager1;
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit7.TabIndex = 5;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(85, 103);
            this.pictureEdit6.MenuManager = this.barManager1;
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit6.TabIndex = 4;
            // 
            // pictureEdit5
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1087, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // textEdit1
            // 
            this.textEdit1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEdit1.EditValue = ((short)(0));
            this.textEdit1.Location = new System.Drawing.Point(38, 692);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.BeepOnError = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit1.Properties.MaskSettings.Set("mask", "C0");
            this.textEdit1.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit1.Size = new System.Drawing.Size(1045, 50);
            this.textEdit1.StyleController = this.layoutForm;
            this.textEdit1.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutAction,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1127, 950);
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
            this.layoutTitle.Size = new System.Drawing.Size(1107, 44);
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
            this.layoutControlItem5});
            this.layoutAction.Location = new System.Drawing.Point(0, 44);
            this.layoutAction.Name = "layoutAction";
            this.layoutAction.Size = new System.Drawing.Size(946, 716);
            this.layoutAction.Text = "Thao tác nhập liệu";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 597);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(19, 19, 20, 20);
            this.layoutControlItem2.Size = new System.Drawing.Size(1083, 90);
            this.layoutControlItem2.Text = "Thanh toán:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.GroupChoosenChair;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 194);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(922, 403);
            this.layoutControlItem5.Text = "ChonGheLayout";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl1;
            this.layoutControlItem3.ImageOptions.Image = global::GUI.Properties.Resources.apply_16x163;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(922, 194);
            this.layoutControlItem3.Text = "ThongTinLayout";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ucChonGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutForm);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucChonGhe";
            this.Size = new System.Drawing.Size(1127, 980);
            this.Load += new System.EventHandler(this.ucChonGhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutForm)).EndInit();
            this.layoutForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlGroup layoutAction;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GroupControl grpSeats;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
