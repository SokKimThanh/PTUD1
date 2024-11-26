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
}
