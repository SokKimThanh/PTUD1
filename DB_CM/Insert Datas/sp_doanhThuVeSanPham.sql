drop proc if exists sp_DoanhThuVe
drop proc if exists sp_DoanhThuSanPham

go
CREATE PROCEDURE sp_DoanhThuVe
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        M.MV_AutoID AS MovieID,
        M.MV_NAME AS MovieName,
        M.MV_PRICE AS TicketPrice,
        COUNT(T.TK_AutoID) AS TotalTickets, -- Tổng số vé bán
        COUNT(T.TK_AutoID) * M.MV_PRICE AS TotalTicketRevenue -- Tổng doanh thu vé
    FROM tbl_DM_Movie M
    LEFT JOIN tbl_DM_Ticket T ON M.MV_AutoID = T.TK_MOVIESCHEDULE_AutoID
    WHERE T.CREATED BETWEEN @StartDate AND @EndDate
    GROUP BY M.MV_AutoID, M.MV_NAME, M.MV_PRICE
    ORDER BY TotalTicketRevenue DESC;
END;

go
CREATE PROCEDURE sp_DoanhThuSanPham
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.PD_AutoID AS ProductID,
        P.PD_NAME AS ProductName,
        P.PD_PRICE AS UnitPrice,
        SUM(BD.BD_QUANTITY) AS TotalQuantitySold, -- Tổng số lượng sản phẩm bán
        SUM(BD.BD_QUANTITY * P.PD_PRICE) AS TotalProductRevenue -- Tổng doanh thu sản phẩm
    FROM tbl_DM_Product P
    LEFT JOIN tbl_DM_BillDetail BD ON P.PD_AutoID = BD.BD_PRODUCT_AutoID
    WHERE BD.CREATED BETWEEN @StartDate AND @EndDate
    GROUP BY P.PD_AutoID, P.PD_NAME, P.PD_PRICE
    ORDER BY TotalProductRevenue DESC;
END;
