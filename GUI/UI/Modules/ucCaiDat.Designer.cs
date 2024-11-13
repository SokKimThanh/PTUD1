namespace GUI.UI.Modules
{
    partial class ucCaiDat
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
            this.layoutMayIn = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutNgonNgu = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboMayIn = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNgonNgu = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMayIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMayIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgonNgu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboMayIn);
            this.layoutControl1.Controls.Add(this.cboNgonNgu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(677, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutMayIn,
            this.emptySpaceItem1,
            this.layoutNgonNgu});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(677, 468);
            this.Root.TextVisible = false;
            // 
            // layoutMayIn
            // 
            this.layoutMayIn.Control = this.cboMayIn;
            this.layoutMayIn.Location = new System.Drawing.Point(0, 0);
            this.layoutMayIn.Name = "layoutMayIn";
            this.layoutMayIn.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutMayIn.Size = new System.Drawing.Size(657, 36);
            this.layoutMayIn.Text = "Máy in:";
            this.layoutMayIn.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(657, 376);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutNgonNgu
            // 
            this.layoutNgonNgu.Control = this.cboNgonNgu;
            this.layoutNgonNgu.Location = new System.Drawing.Point(0, 36);
            this.layoutNgonNgu.Name = "layoutNgonNgu";
            this.layoutNgonNgu.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutNgonNgu.Size = new System.Drawing.Size(657, 36);
            this.layoutNgonNgu.Text = "Ngôn ngữ:";
            this.layoutNgonNgu.TextSize = new System.Drawing.Size(51, 13);
            // 
            // cboMayIn
            // 
            this.cboMayIn.Location = new System.Drawing.Point(81, 18);
            this.cboMayIn.Name = "cboMayIn";
            this.cboMayIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMayIn.Properties.NullText = "";
            this.cboMayIn.Size = new System.Drawing.Size(578, 20);
            this.cboMayIn.StyleController = this.layoutControl1;
            this.cboMayIn.TabIndex = 4;
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.Location = new System.Drawing.Point(81, 54);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgonNgu.Properties.NullText = "";
            this.cboNgonNgu.Size = new System.Drawing.Size(578, 20);
            this.cboNgonNgu.StyleController = this.layoutControl1;
            this.cboNgonNgu.TabIndex = 5;
            // 
            // ucCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucCaiDat";
            this.Size = new System.Drawing.Size(677, 468);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMayIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMayIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgonNgu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutMayIn;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutNgonNgu;
        private DevExpress.XtraEditors.LookUpEdit cboMayIn;
        private DevExpress.XtraEditors.LookUpEdit cboNgonNgu;
    }
}
