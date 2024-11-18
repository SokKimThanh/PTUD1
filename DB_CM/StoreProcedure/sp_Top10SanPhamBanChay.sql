SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <17/11/2024>
-- Description:	<Top 10 san pham ban chay>
-- =============================================
go
drop proc if exists sp_Top10SanPhamBanChay
go
CREATE PROCEDURE sp_Top10SanPhamBanChay
    @StartDate DATETIME,
    @EndDate DATETIME,
    @TopN INT = 10 -- Số lượng sản phẩm muốn lấy
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@TopN)
        P.PD_AutoID AS ProductID,
        P.PD_NAME AS ProductName,
        SUM(BD.BD_QUANTITY) AS TotalSold,
        SUM(BD.BD_QUANTITY * P.PD_PRICE) AS TotalRevenue
    FROM tbl_DM_BillDetail BD
    INNER JOIN tbl_DM_Product P ON BD.BD_PRODUCT_AutoID = P.PD_AutoID
    INNER JOIN tbl_DM_Bill B ON BD.BD_BILL_AutoID = B.BL_AutoID
    WHERE B.CREATED BETWEEN @StartDate AND @EndDate
    GROUP BY P.PD_AutoID, P.PD_NAME
    ORDER BY TotalSold DESC;
END;
