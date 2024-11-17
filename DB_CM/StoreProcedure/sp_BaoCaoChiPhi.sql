SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <17/11/2024>
-- Description:	<Báo cáo chi phí>
-- =============================================
go
drop proc if exists sp_BaoCaoChiPhi
go
CREATE PROCEDURE sp_BaoCaoChiPhi
    @StartDate DATETIME,                    
    @EndDate DATETIME                      
AS
BEGIN
    SET NOCOUNT ON;

    -- CTE: Số liệu nhập hàng
    WITH Received AS (
        SELECT 
            EX.EX_EXTYPE_AutoID AS ProductID,
            SUM(EX.EX_QUANTITY) AS TotalReceived,  
            SUM(EX.EX_PRICE) AS TotalImportCost   
        FROM tbl_SYS_Expense EX
        WHERE EX.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY EX.EX_EXTYPE_AutoID
    ),
    -- CTE: Số liệu bán hàng
    Sold AS (
        SELECT 
            BD.BD_PRODUCT_AutoID AS ProductID,
            SUM(BD.BD_QUANTITY) AS TotalSold,                       
            SUM(BD.BD_QUANTITY * P.PD_PRICE) AS ProductRevenue     
        FROM tbl_DM_BillDetail BD
        INNER JOIN tbl_DM_Bill B ON BD.BD_BILL_AutoID = B.BL_AutoID
        INNER JOIN tbl_DM_Product P ON BD.BD_PRODUCT_AutoID = P.PD_AutoID
        WHERE B.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY BD.BD_PRODUCT_AutoID
    ),
    -- CTE: Loại chi phí
    ExpenseType AS (
        SELECT 
            ET.ET_AutoID AS ExpenseTypeID,
            ET.ET_NAME AS ExpenseTypeName,
            ET.ET_PRODUCT_AutoID AS ProductID
        FROM tbl_DM_ExpenseType ET
        WHERE ET.DELETED = 0
    )
    -- Truy vấn chính với loại chi phí
    SELECT
        ET.ExpenseTypeName AS ExpenseTypeName,
        ISNULL(SUM(R.TotalReceived), 0) AS TotalReceivedQuantity,   -- Tổng số lượng nhập
        ISNULL(SUM(R.TotalImportCost), 0) AS TotalImportCost,       -- Tổng chi phí nhập
        ISNULL(SUM(S.TotalSold), 0) AS TotalSoldQuantity,           -- Tổng số lượng bán
        ISNULL(SUM(S.ProductRevenue), 0) AS TotalRevenue            -- Tổng doanh thu
    FROM tbl_DM_Product PD
    LEFT JOIN Received R ON PD.PD_AutoID = R.ProductID
    LEFT JOIN Sold S ON PD.PD_AutoID = S.ProductID
    LEFT JOIN ExpenseType ET ON PD.PD_AutoID = ET.ProductID
    WHERE PD.DELETED = 0
    GROUP BY PD.PD_AutoID, PD.PD_NAME, ET.ExpenseTypeName
    ORDER BY PD.PD_NAME ASC;
END;


