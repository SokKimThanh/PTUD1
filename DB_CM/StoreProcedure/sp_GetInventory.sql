--Tên sản phẩm.
--Số lượng tồn kho hiện tại.
--Đã bán ra bao nhiêu trong khoảng thời gian nhất định.
--Cảnh báo nếu số lượng tồn kho thấp dưới mức yêu cầu.
drop proc if exists sp_GetInventoryReport
drop proc if exists sp_GetExpenseReport
drop proc if exists sp_GetDetailedExpenseReport
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
