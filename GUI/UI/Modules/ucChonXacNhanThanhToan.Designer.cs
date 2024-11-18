namespace GUI.UI.Modules
{
    partial class ucChonXacNhanThanhToan
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTenPhimGioChieu = new System.Windows.Forms.Label();
            this.layoutTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSeatNames = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ttxTheaterName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutTitle1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatNames.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttxTheaterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ttxTheaterName);
            this.layoutControl1.Controls.Add(this.txtSeatNames);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lblTenPhimGioChieu);
            this.layoutControl1.Controls.Add(this.lblTitle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(795, 617);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTitle,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutTitle1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(795, 617);
            this.Root.TextVisible = false;
            // 
            // lblTenPhimGioChieu
            // 
            this.lblTenPhimGioChieu.BackColor = System.Drawing.Color.White;
            this.lblTenPhimGioChieu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhimGioChieu.ForeColor = System.Drawing.Color.Black;
            this.lblTenPhimGioChieu.Location = new System.Drawing.Point(18, 60);
            this.lblTenPhimGioChieu.Name = "lblTenPhimGioChieu";
            this.lblTenPhimGioChieu.Size = new System.Drawing.Size(759, 43);
            this.lblTenPhimGioChieu.TabIndex = 9;
            this.lblTenPhimGioChieu.Text = "Tên phim | Giờ chiếu";
            this.lblTenPhimGioChieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutTitle
            // 
            this.layoutTitle.Control = this.lblTenPhimGioChieu;
            this.layoutTitle.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutTitle.CustomizationFormText = "Title";
            this.layoutTitle.Location = new System.Drawing.Point(0, 42);
            this.layoutTitle.Name = "layoutTitle";
            this.layoutTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutTitle.Size = new System.Drawing.Size(775, 59);
            this.layoutTitle.Text = "Title";
            this.layoutTitle.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTitle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTitle.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(18, 155);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 444);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 137);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem1.Size = new System.Drawing.Size(775, 460);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // txtSeatNames
            // 
            this.txtSeatNames.Location = new System.Drawing.Point(85, 119);
            this.txtSeatNames.Name = "txtSeatNames";
            this.txtSeatNames.Size = new System.Drawing.Size(304, 20);
            this.txtSeatNames.StyleController = this.layoutControl1;
            this.txtSeatNames.TabIndex = 11;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSeatNames;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(387, 36);
            this.layoutControlItem2.Text = "Tên ghế:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // ttxTheaterName
            // 
            this.ttxTheaterName.Location = new System.Drawing.Point(472, 119);
            this.ttxTheaterName.Name = "ttxTheaterName";
            this.ttxTheaterName.Size = new System.Drawing.Size(305, 20);
            this.ttxTheaterName.StyleController = this.layoutControl1;
            this.ttxTheaterName.TabIndex = 12;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ttxTheaterName;
            this.layoutControlItem3.Location = new System.Drawing.Point(387, 101);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(388, 36);
            this.layoutControlItem3.Text = "Tên phòng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(759, 26);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // layoutTitle1
            // 
            this.layoutTitle1.Control = this.lblTitle;
            this.layoutTitle1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutTitle1.CustomizationFormText = "Title";
            this.layoutTitle1.Location = new System.Drawing.Point(0, 0);
            this.layoutTitle1.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutTitle1.MinSize = new System.Drawing.Size(36, 42);
            this.layoutTitle1.Name = "layoutTitle1";
            this.layoutTitle1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle1.Size = new System.Drawing.Size(775, 42);
            this.layoutTitle1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutTitle1.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutTitle1.Text = "Title";
            this.layoutTitle1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutTitle1.TextVisible = false;
            // 
            // ucChonXacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucChonXacNhanThanhToan";
            this.Size = new System.Drawing.Size(795, 617);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatNames.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttxTheaterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTitle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ttxTheaterName;
        private DevExpress.XtraEditors.TextEdit txtSeatNames;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTenPhimGioChieu;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutTitle1;
    }
}
