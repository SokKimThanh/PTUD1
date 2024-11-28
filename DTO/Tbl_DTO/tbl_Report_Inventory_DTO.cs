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
        public double TotalImportCost { get; set; }
        public double UnitCost { get; set; }
        public double SoldQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalRevenue { get; set; }
        public string RestockStatus { get; set; }
        public double RemainingStock { get; set; }
    } 
}
