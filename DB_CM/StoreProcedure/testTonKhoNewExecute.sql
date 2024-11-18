 
DECLARE @StartDate DATETIME = CAST('2024-01-01' AS DATETIME);
DECLARE @EndDate DATETIME = CAST('2024-12-31' AS DATETIME);
DECLARE @SalesPerformanceThreshold INT = 50;    -- Ngưỡng hiệu suất bán hàng (mặc định 50%)
DECLARE @MinStockThreshold INT = 50;            -- Lượng tồn kho dưới ngưỡng tối thiểu (mặc định 50%)
DECLARE @DesiredProfitMargin FLOAT = 0.2;       -- Lợi nhuận mong muốn (20%)
DECLARE @LoiNhuanVe INT = 0.7;					-- Giả định lợi nhuận vé là 70% doanh thu
DECLARE	@LoiNhuanSanPham INT = 0.5;				-- Giả định lợi nhuận sản phẩm là 50% doanh thu
DECLARE @StockStatus INT= 1;             -- Trạng thái tồn kho: 1 = Cạn kiệt, 2 = Có sẵn, 3 = Quá tải
DECLARE @SalesPerformance INT = 1;        -- Hiệu suất bán hàng: 1 = Bán chậm, 2 = Ổn định, 3 = Cháy hàng
DECLARE @TopN INT = 10;

EXEC sp_TonKhoChiTiet @StartDate, @EndDate, @SalesPerformanceThreshold, @MinStockThreshold, @DesiredProfitMargin;

--EXEC sp_TongHopLoiNhuan @StartDate, @EndDate, @LoiNhuanVe, @LoiNhuanSanPham;

--EXEC sp_DoanhThuVe @StartDate, @EndDate

--EXEC sp_DoanhThuSanPham @StartDate, @EndDate

--EXEC sp_Top10SanPhamBanChay @StartDate, @EndDate, @TopN

--EXEC sp_BaoCaoChiPhi 
--    @StartDate  , 
--    @EndDate  , 
--    @OperatingCost = 500000, 
--    @DesiredProfitMargin = 0.20;

 EXEC sp_DoanhThuVe @StartDate, @EndDate
 EXEC sp_DoanhThuSanPham @StartDate, @EndDate
