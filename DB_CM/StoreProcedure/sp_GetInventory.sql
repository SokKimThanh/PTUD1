SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <22/10/2024>
-- Description:	<Báo cáo chi phí và tồn kho>
-- =============================================

drop proc if exists sp_GetExpenseReport
drop proc if exists sp_GetDetailedExpenseReport
 
-- detail inventory
drop proc if exists sp_GetDetailedInventoryReportByStatusAndDate

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
CREATE PROCEDURE sp_GetDetailedInventoryReportByStatusAndDate
    @StockStatus INT,             -- Trạng thái tồn kho: 1 = Cạn kiệt, 2 = Có sẵn, 3 = Quá tải
    @SalesPerformance INT,        -- Hiệu suất bán hàng: 1 = Bán chậm, 2 = Ổn định, 3 = Cháy hàng
    @StartDate DATETIME,          -- Ngày bắt đầu cho khoảng thời gian
    @EndDate DATETIME             -- Ngày kết thúc cho khoảng thời gian
AS
BEGIN
    SELECT 
        PD.PD_AutoID AS ProductID,
        PD.PD_NAME AS ProductName,

        -- Tính tổng số lượng nhập trong khoảng thời gian
        ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                FROM tbl_SYS_Expense EX
                WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) AS ReceivedQuantity,

        -- Tính tổng số lượng bán trong khoảng thời gian
        ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                FROM tbl_DM_BillDetail BD
                WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0) AS SoldQuantity,

        -- Tồn kho hiện tại: số lượng ban đầu + số lượng nhập - số lượng bán
        (PD.PD_QUANTITY + 
         ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                 FROM tbl_SYS_Expense EX
                 WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                 AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
         ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                 FROM tbl_DM_BillDetail BD
                 WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                 AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) AS CurrentStock,

        PD.PD_PRICE AS UnitPrice,
        (PD.PD_QUANTITY * PD.PD_PRICE) AS TotalInventoryValue,    -- Tổng giá trị tồn kho còn lại
        ISNULL(SUM(BD.BD_QUANTITY * PD.PD_PRICE), 0) AS TotalSoldValue,  -- Tổng tiền đã bán

        -- Xác định Trạng thái tồn kho (Stock Status)
        CASE 
            WHEN (PD.PD_QUANTITY + 
                 ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                         FROM tbl_SYS_Expense EX
                         WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                         AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                 ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                         FROM tbl_DM_BillDetail BD
                         WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                         AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) < 10 THEN N'Cạn kiệt'
            WHEN (PD.PD_QUANTITY + 
                 ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                         FROM tbl_SYS_Expense EX
                         WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                         AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                 ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                         FROM tbl_DM_BillDetail BD
                         WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                         AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) > 100 THEN N'Quá tải'
            ELSE N'Có sẵn'
        END AS StockStatus,

        -- Xác định Hiệu suất bán hàng (Sales Performance)
        CASE 
            WHEN ISNULL(SUM(BD.BD_QUANTITY), 0) < 10 THEN N'Bán chậm'
            WHEN ISNULL(SUM(BD.BD_QUANTITY), 0) BETWEEN 10 AND 50 THEN N'Ổn định'
            ELSE N'Cháy hàng'
        END AS SalesPerformance,

        -- Hành động khuyến nghị dựa trên tồn kho và hiệu suất bán hàng
        CASE 
            WHEN (PD.PD_QUANTITY + 
                 ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                         FROM tbl_SYS_Expense EX
                         WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                         AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                 ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                         FROM tbl_DM_BillDetail BD
                         WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                         AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) < 10 AND ISNULL(SUM(BD.BD_QUANTITY), 0) > 50 THEN N'Cần nhập hàng'
            WHEN (PD.PD_QUANTITY + 
                 ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                         FROM tbl_SYS_Expense EX
                         WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                         AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                 ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                         FROM tbl_DM_BillDetail BD
                         WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                         AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) > 100 AND ISNULL(SUM(BD.BD_QUANTITY), 0) < 10 THEN N'Cân nhắc mở khuyến mãi'
            ELSE N'Tiếp tục bán'
        END AS RecommendedAction

    FROM tbl_DM_Product PD
    LEFT JOIN tbl_DM_BillDetail BD ON PD.PD_AutoID = BD.BD_PRODUCT_AutoID
        AND BD.CREATED BETWEEN @StartDate AND @EndDate -- Chỉ tính số lượng đã bán trong khoảng thời gian
    WHERE PD.DELETED = 0  -- Bỏ qua sản phẩm đã xóa
    GROUP BY PD.PD_AutoID, PD.PD_NAME, PD.PD_QUANTITY, PD.PD_PRICE
    HAVING 
        -- Lọc theo Trạng thái tồn kho
        (
            (@StockStatus = 1 AND (PD.PD_QUANTITY +
                ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                        FROM tbl_SYS_Expense EX
                        WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                        AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                        FROM tbl_DM_BillDetail BD
                        WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                        AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) < 10) OR
            (@StockStatus = 2 AND (PD.PD_QUANTITY +
                ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                        FROM tbl_SYS_Expense EX
                        WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                        AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                        FROM tbl_DM_BillDetail BD
                        WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                        AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) BETWEEN 10 AND 100) OR
            (@StockStatus = 3 AND (PD.PD_QUANTITY +
                ISNULL((SELECT SUM(EX.EX_QUANTITY) 
                        FROM tbl_SYS_Expense EX
                        WHERE EX.EX_EXTYPE_AutoID = PD.PD_AutoID
                        AND EX.CREATED BETWEEN @StartDate AND @EndDate), 0) -
                ISNULL((SELECT SUM(BD.BD_QUANTITY) 
                        FROM tbl_DM_BillDetail BD
                        WHERE BD.BD_PRODUCT_AutoID = PD.PD_AutoID
                        AND BD.CREATED BETWEEN @StartDate AND @EndDate), 0)) > 100)
        )
        AND
        -- Lọc theo Hiệu suất bán hàng
        (
            (@SalesPerformance = 1 AND ISNULL(SUM(BD.BD_QUANTITY), 0) < 10) OR
            (@SalesPerformance = 2 AND ISNULL(SUM(BD.BD_QUANTITY), 0) BETWEEN 10 AND 50) OR
            (@SalesPerformance = 3 AND ISNULL(SUM(BD.BD_QUANTITY), 0) > 50)
        )
    ORDER BY PD.PD_NAME ASC;
END;

  