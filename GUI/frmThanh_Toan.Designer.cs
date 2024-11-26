namespace GUI
{
    partial class frmThanh_Toan
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMa_HD = new DevExpress.XtraEditors.TextEdit();
            this.btnXac_Nhan = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSan_Pham = new DevExpress.XtraEditors.LabelControl();
            this.txtGia = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa_HD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.txtMa_HD);
            this.panelControl1.Controls.Add(this.btnXac_Nhan);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblSan_Pham);
            this.panelControl1.Controls.Add(this.txtGia);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(331, 194);
            this.panelControl1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(22, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 34);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtMa_HD
            // 
            this.txtMa_HD.Location = new System.Drawing.Point(116, 26);
            this.txtMa_HD.Name = "txtMa_HD";
            this.txtMa_HD.Size = new System.Drawing.Size(191, 22);
            this.txtMa_HD.TabIndex = 3;
            // 
            // btnXac_Nhan
            // 
            this.btnXac_Nhan.Location = new System.Drawing.Point(198, 120);
            this.btnXac_Nhan.Name = "btnXac_Nhan";
            this.btnXac_Nhan.Size = new System.Drawing.Size(109, 34);
            this.btnXac_Nhan.TabIndex = 2;
            this.btnXac_Nhan.Text = "Xác nhận";
            this.btnXac_Nhan.UseVisualStyleBackColor = true;
            this.btnXac_Nhan.Click += new System.EventHandler(this.btnXac_Nhan_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Còn lại";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // lblSan_Pham
            // 
            this.lblSan_Pham.Location = new System.Drawing.Point(22, 29);
            this.lblSan_Pham.Name = "lblSan_Pham";
            this.lblSan_Pham.Size = new System.Drawing.Size(47, 16);
            this.lblSan_Pham.TabIndex = 0;
            this.lblSan_Pham.Text = "Hóa đơn";
            // 
            // txtGia
            // 
            this.txtGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGia.Location = new System.Drawing.Point(116, 65);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGia.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtGia.Size = new System.Drawing.Size(191, 24);
            this.txtGia.TabIndex = 4;
            // 
            // frmThanh_Toan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 194);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanh_Toan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số tiền cần thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa_HD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXac_Nhan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblSan_Pham;
        private DevExpress.XtraEditors.TextEdit txtMa_HD;
        private DevExpress.XtraEditors.SpinEdit txtGia;
        private System.Windows.Forms.Button btnHuy;
    }
}