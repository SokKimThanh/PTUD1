﻿namespace GUI.UI.ReportDesign
{
    partial class RP_InventoryDetail
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_InventoryDetail));
            this.RP_StockStatus = new DevExpress.XtraReports.Parameters.Parameter();
            this.RP_SalesPerformance = new DevExpress.XtraReports.Parameters.Parameter();
            this.RP_StartDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.RP_EndDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.panel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalBackground1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // RP_StockStatus
            // 
            this.RP_StockStatus.Name = "RP_StockStatus";
            this.RP_StockStatus.Type = typeof(int);
            this.RP_StockStatus.ValueInfo = "0";
            // 
            // RP_SalesPerformance
            // 
            this.RP_SalesPerformance.Name = "RP_SalesPerformance";
            this.RP_SalesPerformance.Type = typeof(int);
            this.RP_SalesPerformance.ValueInfo = "0";
            // 
            // RP_StartDate
            // 
            this.RP_StartDate.Name = "RP_StartDate";
            this.RP_StartDate.Type = typeof(System.DateTime);
            this.RP_StartDate.ValueInfo = "2024-01-01";
            // 
            // RP_EndDate
            // 
            this.RP_EndDate.Name = "RP_EndDate";
            this.RP_EndDate.Type = typeof(System.DateTime);
            this.RP_EndDate.ValueInfo = "2024-12-31";
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.label1,
            this.xrTable1});
            this.ReportHeader.HeightF = 215.0182F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.panel1});
            this.ReportFooter.HeightF = 49.38444F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(313.5F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(313.5F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(313.5F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("Arial", 24.63F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 144.7917F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(627F, 41.43842F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BÁO CÁO TỒN KHO CHI TIẾT";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(627.0001F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "DetailCaption1";
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.Text = "Tên SP";
            this.tableCell1.Weight = 0.0898942475874078D;
            // 
            // tableCell3
            // 
            this.tableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "SL Bán";
            this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell3.Weight = 0.078161834452150331D;
            // 
            // tableCell4
            // 
            this.tableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "DetailCaption1";
            this.tableCell4.StylePriority.UseFont = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "SL Tồn Kho";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell4.Weight = 0.096617081026131674D;
            // 
            // tableCell5
            // 
            this.tableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "Đơn giá";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell5.Weight = 0.10423139812132404D;
            // 
            // tableCell6
            // 
            this.tableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.StylePriority.UseTextAlignment = false;
            this.tableCell6.Text = "Tổng vốn kho";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell6.Weight = 0.10611802488390276D;
            // 
            // tableCell7
            // 
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "Thành tiền";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell7.Weight = 0.084277083696764343D;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(627F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell11,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15,
            this.tableCell16,
            this.tableCell17});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // tableCell11
            // 
            this.tableCell11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.tableCell11.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailData1";
            this.tableCell11.StylePriority.UseBorders = false;
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.Weight = 0.089894241503361116D;
            // 
            // tableCell13
            // 
            this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoldQuantity]")});
            this.tableCell13.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailData1";
            this.tableCell13.StylePriority.UseFont = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell13.TextFormatString = "{0:N0}";
            this.tableCell13.Weight = 0.078161848602679981D;
            // 
            // tableCell14
            // 
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CurrentStock]")});
            this.tableCell14.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailData1";
            this.tableCell14.StylePriority.UseFont = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell14.TextFormatString = "{0:N0}";
            this.tableCell14.Weight = 0.096617054707508657D;
            // 
            // tableCell15
            // 
            this.tableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "DetailData1";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell15.TextFormatString = "{0:C0}";
            this.tableCell15.Weight = 0.10423131798190494D;
            // 
            // tableCell16
            // 
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalInventoryValue]")});
            this.tableCell16.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "DetailData1";
            this.tableCell16.StylePriority.UseFont = false;
            this.tableCell16.StylePriority.UseTextAlignment = false;
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell16.TextFormatString = "{0:C0}";
            this.tableCell16.Weight = 0.10611816198981174D;
            // 
            // tableCell17
            // 
            this.tableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalSoldValue]")});
            this.tableCell17.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "DetailData1";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell17.TextFormatString = "{0:C0}";
            this.tableCell17.Weight = 0.084277002394087752D;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.panel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.SizeF = new System.Drawing.SizeF(627F, 49.38444F);
            this.panel1.StyleName = "GrandTotalBackground1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "CM_Cinema_DB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_GetDetailedInventoryReportByStatusAndDate";
            queryParameter1.Name = "@StockStatus";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?RP_StockStatus", typeof(int));
            queryParameter2.Name = "@SalesPerformance";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?RP_SalesPerformance", typeof(int));
            queryParameter3.Name = "@StartDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?RP_StartDate", typeof(System.DateTime));
            queryParameter4.Name = "@EndDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?RP_EndDate", typeof(System.DateTime));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4});
            storedProcQuery1.StoredProcName = "sp_GetDetailedInventoryReportByStatusAndDate";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
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
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
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
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalCaption1
            // 
            this.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.GrandTotalCaption1.Name = "GrandTotalCaption1";
            this.GrandTotalCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalData1
            // 
            this.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GrandTotalData1.Name = "GrandTotalData1";
            this.GrandTotalData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalBackground1
            // 
            this.GrandTotalBackground1.BackColor = System.Drawing.Color.White;
            this.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GrandTotalBackground1.BorderWidth = 2F;
            this.GrandTotalBackground1.Name = "GrandTotalBackground1";
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 186.2301F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(627.0001F, 28.7881F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 3.9736679855521246D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Từ:";
            this.xrTableCell1.Weight = 41.766357573976144D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?RP_StartDate")});
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "xrLabel4";
            this.xrTableCell2.TextFormatString = "{0:d}";
            this.xrTableCell2.Weight = 95.590390541146576D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Đến:";
            this.xrTableCell3.Weight = 51.041610831301618D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?RP_EndDate")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Text = "xrLabel5";
            this.xrTableCell4.TextFormatString = "{0:d}";
            this.xrTableCell4.Weight = 109.43502053288186D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StockStatus]")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.xrTableCell5.ForeColor = System.Drawing.Color.Red;
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.Text = "xrLabel1";
            this.xrTableCell5.Weight = 115.72506728217994D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalesPerformance]")});
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.xrTableCell6.ForeColor = System.Drawing.Color.Red;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.Text = "xrLabel2";
            this.xrTableCell6.Weight = 118.96316545626227D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RecommendedAction]")});
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 11F);
            this.xrTableCell7.ForeColor = System.Drawing.Color.Red;
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.Text = "xrLabel3";
            this.xrTableCell7.Weight = 94.47845453945375D;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(188.3984F, 9.999974F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(438.6016F, 29.38447F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1.4037717574527133D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new DevExpress.Drawing.DXFont("Arial", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StyleName = "GrandTotalCaption1";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Text = "Tổng tiền đã bán";
            this.xrTableCell8.Weight = 45.235122124545939D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TotalSoldValue])")});
            this.xrTableCell9.Font = new DevExpress.Drawing.DXFont("Arial", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StyleName = "GrandTotalData1";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell9.Summary = xrSummary1;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell9.TextFormatString = "{0:C0}";
            this.xrTableCell9.Weight = 42.880814154750936D;
            this.xrTableCell9.WordWrap = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(627.0001F, 144.7917F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // RP_InventoryDetail
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "sp_GetDetailedInventoryReportByStatusAndDate";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.RP_StockStatus,
            this.RP_SalesPerformance,
            this.RP_StartDate,
            this.RP_EndDate});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.GrandTotalCaption1,
            this.GrandTotalData1,
            this.GrandTotalBackground1,
            this.PageInfo});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.Parameters.Parameter RP_StockStatus;
        private DevExpress.XtraReports.Parameters.Parameter RP_SalesPerformance;
        private DevExpress.XtraReports.Parameters.Parameter RP_StartDate;
        private DevExpress.XtraReports.Parameters.Parameter RP_EndDate;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPanel panel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalData1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalBackground1;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
    }
}
