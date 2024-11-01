namespace DTO.tbl_DTO

{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DTO
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public double CurrentStock { get; set; }
        public double SoldQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalInventoryValue { get; set; }
        public string StockStatus { get; set; }
        public string SalesPerformance { get; set; }
        public string RecommendedAction { get; set; }
    }
}
