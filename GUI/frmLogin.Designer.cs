namespace GUI
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutDangNhap = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTenDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutBtnDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.svgImageBox1);
            this.layoutControl1.Controls.Add(this.btnDangNhap);
            this.layoutControl1.Controls.Add(this.txtMatKhau);
            this.layoutControl1.Controls.Add(this.txtTenDangNhap);
            this.layoutControl1.Controls.Add(this.btnThoat);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(864, 312, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(960, 552);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(162, 182);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(313, 209);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 8;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ImageOptions.Image = global::GUI.Properties.Resources.apply_16x161;
            this.btnDangNhap.Location = new System.Drawing.Point(489, 306);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDangNhap.Size = new System.Drawing.Size(303, 22);
            this.btnDangNhap.StyleController = this.layoutControl1;
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(489, 266);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(303, 20);
            this.txtMatKhau.StyleController = this.layoutControl1;
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(489, 207);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(303, 20);
            this.txtTenDangNhap.StyleController = this.layoutControl1;
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = global::GUI.Properties.Resources.borules_16x16;
            this.btnThoat.Location = new System.Drawing.Point(489, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(303, 22);
            this.btnThoat.StyleController = this.layoutControl1;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Root
            // 
            this.Root.AppearanceGroup.BackColor = System.Drawing.Color.Transparent;
            this.Root.AppearanceGroup.Options.UseBackColor = true;
            this.Root.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.Root.AppearanceItemCaption.Options.UseBackColor = true;
            this.Root.BackgroundImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Root.BackgroundImageOptions.Image")));
            this.Root.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Root.CaptionImageOptions.Image")));
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutDangNhap});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(960, 552);
            this.Root.Spacing = new DevExpress.XtraLayout.Utils.Padding(128, 128, 128, 128);
            this.Root.TextVisible = false;
            // 
            // layoutDangNhap
            // 
            this.layoutDangNhap.CaptionImageOptions.Image = global::GUI.Properties.Resources.encrypt_16x16;
            this.layoutDangNhap.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTenDangNhap,
            this.layoutBtnDangNhap,
            this.layoutMatKhau,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutDangNhap.Location = new System.Drawing.Point(0, 0);
            this.layoutDangNhap.Name = "layoutDangNhap";
            this.layoutDangNhap.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 16, 16);
            this.layoutDangNhap.Size = new System.Drawing.Size(686, 280);
            this.layoutDangNhap.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutDangNhap.Text = "Đăng nhập hệ thống";
            // 
            // layoutTenDangNhap
            // 
            this.layoutTenDangNhap.Control = this.txtTenDangNhap;
            this.layoutTenDangNhap.ImageOptions.Image = global::GUI.Properties.Resources.editname_16x16;
            this.layoutTenDangNhap.Location = new System.Drawing.Point(321, 0);
            this.layoutTenDangNhap.Name = "layoutTenDangNhap";
            this.layoutTenDangNhap.Size = new System.Drawing.Size(323, 59);
            this.layoutTenDangNhap.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutTenDangNhap.Text = "Tên đăng nhập";
            this.layoutTenDangNhap.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTenDangNhap.TextSize = new System.Drawing.Size(93, 16);
            // 
            // layoutBtnDangNhap
            // 
            this.layoutBtnDangNhap.Control = this.btnDangNhap;
            this.layoutBtnDangNhap.ImageOptions.Image = global::GUI.Properties.Resources.iconsetsigns3_16x16;
            this.layoutBtnDangNhap.Location = new System.Drawing.Point(321, 118);
            this.layoutBtnDangNhap.Name = "layoutBtnDangNhap";
            this.layoutBtnDangNhap.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutBtnDangNhap.Size = new System.Drawing.Size(323, 42);
            this.layoutBtnDangNhap.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutBtnDangNhap.Text = "Đăng nhập";
            this.layoutBtnDangNhap.TextSize = new System.Drawing.Size(0, 0);
            this.layoutBtnDangNhap.TextVisible = false;
            // 
            // layoutMatKhau
            // 
            this.layoutMatKhau.Control = this.txtMatKhau;
            this.layoutMatKhau.ImageOptions.Image = global::GUI.Properties.Resources.show_16x16;
            this.layoutMatKhau.Location = new System.Drawing.Point(321, 59);
            this.layoutMatKhau.Name = "layoutMatKhau";
            this.layoutMatKhau.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutMatKhau.Size = new System.Drawing.Size(323, 59);
            this.layoutMatKhau.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutMatKhau.Text = "Mật khẩu";
            this.layoutMatKhau.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutMatKhau.TextSize = new System.Drawing.Size(93, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.svgImageBox1;
            this.layoutControlItem2.CustomizationFormText = "LogoTeam";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 217);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Text = "LogoTeam";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnThoat;
            this.layoutControlItem1.Location = new System.Drawing.Point(321, 160);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(323, 57);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem1.Text = "Thoát";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(960, 552);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::GUI.Properties.Resources.Logo;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem layoutBtnDangNhap;
        private DevExpress.XtraLayout.LayoutControlGroup layoutDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}