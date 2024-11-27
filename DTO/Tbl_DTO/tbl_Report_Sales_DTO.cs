namespace DTO.tbl_DTO
{
    /// <summary>
    /// Báo cáo doanh thu
    /// </summary>
    public class tbl_Report_Sales_DTO
    {
        public string MovieName { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalTicketsSold { get; set; }
    }
    public class TicketRevenueDTO
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public decimal TicketPrice { get; set; }
        public int TotalTickets { get; set; }
        public decimal TotalTicketRevenue { get; set; }
    }
    public class ProductRevenueDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int TotalQuantitySold { get; set; }
        public decimal TotalProductRevenue { get; set; }
    }
}
