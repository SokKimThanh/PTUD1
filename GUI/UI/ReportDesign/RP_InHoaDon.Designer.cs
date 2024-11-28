namespace GUI.UI.ReportDesign
{
    partial class RP_InHoaDon
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_InHoaDon));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.prmBillAutoID = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTinhTrang = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtNgayIn = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNgayIn = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // prmBillAutoID
            // 
            this.prmBillAutoID.Name = "prmBillAutoID";
            this.prmBillAutoID.Type = typeof(long);
            this.prmBillAutoID.ValueInfo = "0";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 254F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 254F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel13,
            this.xrLabel12,
            this.txtTinhTrang,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.txtNgayIn,
            this.lblNgayIn,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel2,
            this.xrPictureBox1,
            this.label1});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 698.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Dpi = 254F;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BeginTime]")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(1164.567F, 582.1536F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(461.4333F, 77.47003F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "xrLabel9";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel16.TextFormatString = "{0:dd/MM/yyyy HH:mm}";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Dpi = 254F;
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(825.5F, 582.1536F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Suất chiếu: ";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Dpi = 254F;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TicketPrice]")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(364.0667F, 582.1536F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(461.4333F, 77.47003F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "xrLabel9";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Dpi = 254F;
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 582.1536F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Giá vé: ";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Dpi = 254F;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MovieName]")});
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(364.0667F, 493.2536F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(461.4333F, 77.47003F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel9";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 493.2536F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Phim: ";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Dpi = 254F;
            this.txtTinhTrang.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.txtTinhTrang.LocationFloat = new DevExpress.Utils.PointFloat(1164.567F, 315.4536F);
            this.txtTinhTrang.Multiline = true;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtTinhTrang.SizeF = new System.Drawing.SizeF(461.4333F, 77.47F);
            this.txtTinhTrang.StylePriority.UseFont = false;
            this.txtTinhTrang.StylePriority.UseTextAlignment = false;
            this.txtTinhTrang.Text = "Tình trạng:";
            this.txtTinhTrang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NoTicket]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(364.0667F, 408.5869F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(461.4333F, 77.47003F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 408.5869F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Số vé: ";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(825.5F, 315.4536F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Tình trạng: ";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // txtNgayIn
            // 
            this.txtNgayIn.Dpi = 254F;
            this.txtNgayIn.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.txtNgayIn.LocationFloat = new DevExpress.Utils.PointFloat(1164.567F, 493.2536F);
            this.txtNgayIn.Multiline = true;
            this.txtNgayIn.Name = "txtNgayIn";
            this.txtNgayIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtNgayIn.SizeF = new System.Drawing.SizeF(461.4335F, 77.47F);
            this.txtNgayIn.StylePriority.UseFont = false;
            this.txtNgayIn.StylePriority.UseTextAlignment = false;
            this.txtNgayIn.Text = "dd/MM/yyyy";
            this.txtNgayIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.txtNgayIn.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // lblNgayIn
            // 
            this.lblNgayIn.Dpi = 254F;
            this.lblNgayIn.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblNgayIn.LocationFloat = new DevExpress.Utils.PointFloat(825.5F, 493.2536F);
            this.lblNgayIn.Multiline = true;
            this.lblNgayIn.Name = "lblNgayIn";
            this.lblNgayIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblNgayIn.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.lblNgayIn.StylePriority.UseFont = false;
            this.lblNgayIn.StylePriority.UseTextAlignment = false;
            this.lblNgayIn.Text = "Ngày in: ";
            this.lblNgayIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StaffName]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1164.567F, 408.5869F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(461.4334F, 77.47003F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(825.5F, 408.5869F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(339.0666F, 77.47F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Nhân viên: ";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(24.99999F, 315.4536F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(339.0666F, 77.46997F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Mã HĐ:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?prmBillAutoID")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 13F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(364.0667F, 315.4536F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(461.4333F, 77.46997F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(254F, 52.91666F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(773.4132F, 58.41999F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Công ty IRT - Giải pháp công nghệ Việt Nam";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(254F, 139.1709F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(773.4132F, 58.42F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Địa chỉ: 53 Võ Văn Ngân, Thủ Đức, TP.HCM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::GUI.Properties.Resources.Logo, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(254F, 254F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // label1
            // 
            this.label1.Dpi = 254F;
            this.label1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 254F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(1651F, 61.45361F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Hóa đơn thanh toán";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 71.12F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.Dpi = 254F;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(24.99994F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(1601F, 71.12F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9});
            this.tableRow1.Dpi = 254F;
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell6
            // 
            this.tableCell6.Dpi = 254F;
            this.tableCell6.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.Text = "Tên sản phẩm";
            this.tableCell6.Weight = 0.44106152007689392D;
            // 
            // tableCell7
            // 
            this.tableCell7.Dpi = 254F;
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "SL";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell7.Weight = 0.097798699252465357D;
            // 
            // tableCell8
            // 
            this.tableCell8.Dpi = 254F;
            this.tableCell8.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.StylePriority.UseTextAlignment = false;
            this.tableCell8.Text = "Đơn giá";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell8.Weight = 0.21874111099362648D;
            // 
            // tableCell9
            // 
            this.tableCell9.Dpi = 254F;
            this.tableCell9.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailCaption1";
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.StylePriority.UseTextAlignment = false;
            this.tableCell9.Text = "Thành tiền";
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell9.Weight = 0.21211417473791591D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 63.84365F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.Dpi = 254F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(25.00005F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1601F, 63.42F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15,
            this.tableCell16,
            this.tableCell17,
            this.tableCell18});
            this.tableRow2.Dpi = 254F;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.683999633789062D;
            // 
            // tableCell15
            // 
            this.tableCell15.Dpi = 254F;
            this.tableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F);
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "DetailData1";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.Weight = 0.44106138850747623D;
            // 
            // tableCell16
            // 
            this.tableCell16.Dpi = 254F;
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.tableCell16.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F);
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "DetailData1";
            this.tableCell16.StylePriority.UseFont = false;
            this.tableCell16.StylePriority.UseTextAlignment = false;
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell16.Weight = 0.097798643799570123D;
            // 
            // tableCell17
            // 
            this.tableCell17.Dpi = 254F;
            this.tableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BasePrice]")});
            this.tableCell17.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F);
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "DetailData1";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell17.Weight = 0.21874107649682617D;
            // 
            // tableCell18
            // 
            this.tableCell18.Dpi = 254F;
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]*[BasePrice]")});
            this.tableCell18.Font = new DevExpress.Drawing.DXFont("times New Roman", 13F);
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StyleName = "DetailData1";
            this.tableCell18.StylePriority.UseFont = false;
            this.tableCell18.StylePriority.UseTextAlignment = false;
            this.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell18.Weight = 0.21211416900954966D;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel10,
            this.xrLabel11});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 266.7303F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel20
            // 
            this.xrLabel20.Dpi = 254F;
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Arial", 13F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(914.6581F, 95.25001F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(361.1414F, 77.47F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Số tiền còn lại: ";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Dpi = 254F;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalPrice]-[Payed]")});
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Arial", 13F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1275.799F, 95.25001F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(350.2004F, 77.47F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel21.Summary = xrSummary1;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Dpi = 254F;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Payed]")});
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Arial", 13F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(1275.799F, 0F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(350.2004F, 77.47F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            xrSummary2.IgnoreNullValues = true;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel18.Summary = xrSummary2;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Dpi = 254F;
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Arial", 13F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(914.6579F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(361.1414F, 77.47F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Số tiền đã trả:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Arial", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(914.6579F, 189.2603F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(361.1414F, 77.47F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Tổng tiền:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalPrice]")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Arial", 13F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(1275.799F, 189.2603F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(350.2004F, 77.47F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            xrSummary3.IgnoreNullValues = true;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel11.Summary = xrSummary3;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "CM_Cinema_DB";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery1.Name = "sp_HoaDon_BaoCao";
            queryParameter1.Name = "@Bill_AutoID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?prmBillAutoID", typeof(long));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "sp_HoaDon_BaoCao";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "CM_Cinema_DB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "sp_HoaDon_BaoCao";
            queryParameter2.Name = "@Bill_AutoID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?prmBillAutoID", typeof(long));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2});
            storedProcQuery2.StoredProcName = "sp_HoaDon_BaoCao";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // RP_InHoaDon
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource2,
            this.sqlDataSource1});
            this.DataMember = "sp_HoaDon_BaoCao";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(254F, 254F, 254F, 254F);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmBillAutoID});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.Parameters.Parameter prmBillAutoID;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel txtNgayIn;
        private DevExpress.XtraReports.UI.XRLabel lblNgayIn;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel txtTinhTrang;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
    }
}
