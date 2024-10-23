namespace DTO.tbl_DTO

{
    /// <summary>
    /// Báo cáo tồn kho
    /// </summary>
    public class tbl_Report_Inventory_DTO
    {
        public string ProductName { get; set; }
        public float CurrentStock { get; set; }
        public float SoldQuantity { get; set; }
    }
}
