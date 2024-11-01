--Tên sản phẩm.
--Số lượng tồn kho hiện tại.
--Đã bán ra bao nhiêu trong khoảng thời gian nhất định.
--Cảnh báo nếu số lượng tồn kho thấp dưới mức yêu cầu.
drop proc if exists sp_GetInventoryReport
drop proc if exists sp_GetDetailedInventoryReport
drop proc if exists sp_GetExpenseReport
drop proc if exists sp_GetDetailedExpenseReport
drop proc if exists sp_GetInventoryReportByStatus
drop proc if exists sp_GetDetailedInventoryReportByStatus
go
CREATE PROCEDURE sp_GetInventoryReport
AS
BEGIN
    SELECT 
        PD.PD_NAME AS ProductName,          -- Tên sản phẩm
        PD.PD_QUANTITY AS CurrentStock,     -- Số lượng hiện có trong kho
        ISNULL(SUM(BL.BL_QUANTITY), 0) AS SoldQuantity -- Số lượng đã bán (nếu có)
    FROM tbl_DM_Product PD
    LEFT JOIN tbl_DM_Bill BL ON PD.PD_AutoID = BL.BL_PRODUCT_AutoID
    WHERE PD.DELETED = 0                   -- Bỏ qua các sản phẩm đã xóa
    GROUP BY PD.PD_NAME, PD.PD_QUANTITY;
END;


go
CREATE PROCEDURE sp_GetExpenseReport
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
        SUM(EX.EX_PRICE * EX.EX_QUANTITY) AS TotalExpenses, -- Tổng chi phí
        COUNT(EX.EX_AutoID) AS NumberOfExpenses             -- Số lượng chi phí
    FROM tbl_SYS_Expense EX
    WHERE EX.CREATED BETWEEN @StartDate AND @EndDate       -- Khoảng thời gian
    AND EX.DELETED = 0;                                    -- Bỏ qua các chi phí đã xóa
END;

go
CREATE PROCEDURE sp_GetDetailedExpenseReport
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
        EX.EX_AutoID,              -- ID của chi phí
        EX.EX_EXTYPE_AutoID,       -- ID loại chi phí
        ET.ET_NAME AS ExpenseType, -- Tên loại chi phí (JOIN từ bảng loại chi phí)
        EX.EX_QUANTITY,            -- Số lượng chi phí
        EX.EX_PRICE,               -- Đơn giá của chi phí
        (EX.EX_PRICE * EX.EX_QUANTITY) AS TotalCost, -- Tổng chi phí (đơn giá * số lượng)
        EX.EX_REASON,              -- Lý do hoặc mô tả chi phí
        EX.CREATED                 -- Ngày tạo chi phí
    FROM tbl_SYS_Expense EX
    LEFT JOIN tbl_DM_ExpenseType ET ON EX.EX_EXTYPE_AutoID = ET.ET_AutoID -- Kết nối với bảng loại chi phí
    WHERE EX.CREATED BETWEEN @StartDate AND @EndDate  -- Lọc theo khoảng thời gian
    AND EX.DELETED = 0                               -- Bỏ qua các chi phí đã xóa
    ORDER BY EX.CREATED ASC;                         -- Sắp xếp theo ngày tạo chi phí
END;


go
CREATE PROCEDURE sp_GetDetailedInventoryReport
AS
BEGIN
    SELECT 
        PD.PD_AutoID,                             -- ID của sản phẩm
        PD.PD_NAME AS ProductName,                -- Tên sản phẩm
		PD.PD_IMAGEURL as ProductImageUrl,			-- Hình sản phẩm
        PD.PD_QUANTITY AS CurrentStock,           -- Số lượng tồn kho hiện có
        ISNULL(SUM(BL.BL_QUANTITY), 0) AS SoldQuantity, -- Số lượng đã bán, dùng SUM và ISNULL để tránh giá trị NULL
        PD.PD_PRICE AS UnitPrice,                 -- Giá đơn vị sản phẩm
        (PD.PD_QUANTITY * PD.PD_PRICE) AS TotalInventoryValue -- Tổng giá trị tồn kho còn lại
    FROM tbl_DM_Product PD
    LEFT JOIN tbl_DM_Bill BL ON PD.PD_AutoID = BL.BL_PRODUCT_AutoID -- JOIN với bảng hóa đơn để lấy số lượng đã bán
    WHERE PD.DELETED = 0                             -- Bỏ qua các sản phẩm đã xóa
    GROUP BY PD.PD_AutoID, PD.PD_NAME, PD.PD_IMAGEURL, PD.PD_QUANTITY, PD.PD_PRICE -- Nhóm theo thông tin sản phẩm
    ORDER BY PD.PD_NAME ASC;                         -- Sắp xếp theo tên sản phẩm
END;

go
CREATE PROCEDURE sp_GetInventoryReportByStatus
    @StockStatus INT  -- Trạng thái tồn kho: 1 = Low Stock, 2 = In Stock, 3 = Overstocked
AS
BEGIN
    SELECT 
        PD.PD_AutoID AS ProductID,
        PD.PD_NAME AS ProductName,
        PD.PD_QUANTITY AS CurrentStock,
        PD.PD_PRICE AS UnitPrice,
        ISNULL(SUM(BL.BL_QUANTITY), 0) AS SoldQuantity,  -- Tổng số lượng đã bán
        (PD.PD_QUANTITY * PD.PD_PRICE) AS TotalInventoryValue,  -- Tổng giá trị tồn kho còn lại
        CASE 
            WHEN PD.PD_QUANTITY < 10 THEN 'Low Stock'
            WHEN PD.PD_QUANTITY > 100 THEN 'Overstocked'
            ELSE 'In Stock'
        END AS StockStatus
    FROM tbl_DM_Product PD
    LEFT JOIN tbl_DM_Bill BL ON PD.PD_AutoID = BL.BL_PRODUCT_AutoID
    WHERE PD.DELETED = 0  -- Bỏ qua sản phẩm đã xóa
    GROUP BY PD.PD_AutoID, PD.PD_NAME, PD.PD_QUANTITY, PD.PD_PRICE
    HAVING ( @StockStatus = 1 AND PD.PD_QUANTITY < 10 ) OR
           ( @StockStatus = 2 AND PD.PD_QUANTITY BETWEEN 10 AND 100 ) OR
           ( @StockStatus = 3 AND PD.PD_QUANTITY > 100 )
    ORDER BY PD.PD_NAME ASC;
END;

go
CREATE PROCEDURE sp_GetDetailedInventoryReportByStatus
    @StockStatus INT,          -- 1 = Low Stock, 2 = In Stock, 3 = Overstocked
    @SalesPerformance INT      -- 1 = Slow, 2 = Moderate, 3 = Fast
AS
BEGIN
    SELECT 
        PD.PD_AutoID AS ProductID,
        PD.PD_NAME AS ProductName,
        PD.PD_QUANTITY AS CurrentStock,
        ISNULL(SUM(BL.BL_QUANTITY), 0) AS SoldQuantity,  -- Tổng số lượng đã bán
        PD.PD_PRICE AS UnitPrice,
        (PD.PD_QUANTITY * PD.PD_PRICE) AS TotalInventoryValue,
        
        -- Xác định Trạng thái tồn kho (Stock Status)
        CASE 
            WHEN PD.PD_QUANTITY < 10 THEN 'Low Stock'
            WHEN PD.PD_QUANTITY > 100 THEN 'Overstocked'
            ELSE 'In Stock'
        END AS StockStatus,
        
        -- Xác định Hiệu suất bán hàng (Sales Performance)
        CASE 
            WHEN ISNULL(SUM(BL.BL_QUANTITY), 0) < 10 THEN 'Slow'
            WHEN ISNULL(SUM(BL.BL_QUANTITY), 0) BETWEEN 10 AND 50 THEN 'Moderate'
            ELSE 'Fast'
        END AS SalesPerformance,
        
        -- Hành động khuyến nghị dựa trên tồn kho và hiệu suất bán hàng
        CASE 
            WHEN PD.PD_QUANTITY < 10 AND ISNULL(SUM(BL.BL_QUANTITY), 0) > 50 THEN 'Order More Stock'
            WHEN PD.PD_QUANTITY > 100 AND ISNULL(SUM(BL.BL_QUANTITY), 0) < 10 THEN 'Consider Promotion'
            ELSE 'Maintain Stock Level'
        END AS RecommendedAction

    FROM tbl_DM_Product PD
    LEFT JOIN tbl_DM_Bill BL ON PD.PD_AutoID = BL.BL_PRODUCT_AutoID  -- JOIN với bảng Bill để lấy số lượng đã bán
    WHERE PD.DELETED = 0  -- Bỏ qua sản phẩm đã xóa
    GROUP BY PD.PD_AutoID, PD.PD_NAME, PD.PD_QUANTITY, PD.PD_PRICE
    HAVING 
        -- Lọc theo Trạng thái tồn kho
        (
            (@StockStatus = 1 AND PD.PD_QUANTITY < 10) OR
            (@StockStatus = 2 AND PD.PD_QUANTITY BETWEEN 10 AND 100) OR
            (@StockStatus = 3 AND PD.PD_QUANTITY > 100)
        )
        AND
        -- Lọc theo Hiệu suất bán hàng
        (
            (@SalesPerformance = 1 AND ISNULL(SUM(BL.BL_QUANTITY), 0) < 10) OR
            (@SalesPerformance = 2 AND ISNULL(SUM(BL.BL_QUANTITY), 0) BETWEEN 10 AND 50) OR
            (@SalesPerformance = 3 AND ISNULL(SUM(BL.BL_QUANTITY), 0) > 50)
        )
    ORDER BY PD.PD_NAME ASC;
END;
