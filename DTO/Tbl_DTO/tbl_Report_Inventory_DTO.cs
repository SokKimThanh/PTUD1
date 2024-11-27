namespace DTO.tbl_DTO

{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DTO
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public double ReceivedQuantity { get; set; }
        public double RemainingStock { get; set; }
        public double SoldQuantity { get; set; }
        public double TotalReceived { get; set; }
        public double TotalSold { get; set; }
        public double SalesPerformancePercentage { get; set; }
        public string SalesPerformanceCategory { get; set; }
        public string StockStatus { get; set; }
        public double TotalImportCost { get; set; }
        public double TotalRevenue { get; set; }
        public double Profit { get; set; }
        public int InventoryStatus { get; set; }
    }
}
