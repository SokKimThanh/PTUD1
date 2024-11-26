namespace DAL.tbl_DAL
{
    public static class InventorySettings
    {
        // Trạng thái tồn kho
        public const int LowStockThreshold = 10;     // Ngưỡng để xác định "Cạn kiệt"
        public const int OverstockThreshold = 100;   // Ngưỡng để xác định "Quá tải"

        // Hiệu suất bán hàng
        public const int SlowSalesThreshold = 10;    // Ngưỡng để xác định "Bán chậm"
        public const int StableSalesThreshold = 50;  // Ngưỡng trên để xác định "Ổn định" 
    }
}
