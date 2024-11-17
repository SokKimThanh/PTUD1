SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <17/11/2024>
-- Description:	<Báo cáo tổng hợp lợi nhuận>
-- =============================================
go
drop proc if exists sp_TongHopLoiNhuan
go
CREATE PROCEDURE sp_TongHopLoiNhuan
    @StartDate DATETIME, -- Ngày bắt đầu
    @EndDate DATETIME,   -- Ngày kết thúc
	@LoiNhuanVe INT = 0.7, -- Giả định lợi nhuận vé là 70% doanh thu
	@LoiNhuanSanPham INT = 0.5 -- Giả định lợi nhuận sản phẩm là 50% doanh thu
AS
BEGIN
    SET NOCOUNT ON;

    -- CTE cho số liệu vé (Ticket)
    WITH TicketData AS (
        SELECT 
            MV.MV_AutoID AS MovieID, 
            MV.MV_NAME AS MovieName,
            COUNT(TK.TK_AutoID) AS TicketCount, -- Số lượng vé
            SUM(MV.MV_PRICE) AS TicketRevenue -- Doanh thu từ vé
        FROM tbl_DM_Ticket TK
        INNER JOIN tbl_DM_MovieSchedule MS ON TK.TK_MOVIESCHEDULE_AutoID = MS.MS_AutoID
        INNER JOIN tbl_DM_Movie MV ON MS.MS_MOVIE_AutoID = MV.MV_AutoID
        WHERE TK.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY MV.MV_AutoID, MV.MV_NAME
    ),

    -- CTE cho số liệu sản phẩm (Product)
    ProductData AS (
        SELECT 
            BD.BD_PRODUCT_AutoID AS ProductID,
            P.PD_NAME AS ProductName,
            COUNT(BD.BD_QUANTITY) AS ProductCount, -- Số lượng sản phẩm
            SUM(BD.BD_QUANTITY * P.PD_PRICE) AS ProductRevenue -- Doanh thu từ sản phẩm
        FROM tbl_DM_BillDetail BD
        INNER JOIN tbl_DM_Bill B ON BD.BD_BILL_AutoID = B.BL_AutoID
        INNER JOIN tbl_DM_Product P ON BD.BD_PRODUCT_AutoID = P.PD_AutoID
        WHERE B.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY BD.BD_PRODUCT_AutoID, P.PD_NAME
    ),

    -- Kết hợp dữ liệu vé và sản phẩm
    CombinedData AS (
        SELECT 
            T.MovieID,
            T.MovieName,
            ISNULL(T.TicketCount, 0) AS TicketCount, 
            ISNULL(T.TicketRevenue, 0) AS TicketRevenue,
            ISNULL(SUM(P.ProductCount), 0) AS TotalProductCount, 
            ISNULL(SUM(P.ProductRevenue), 0) AS TotalProductRevenue,
            ISNULL(T.TicketRevenue, 0) + ISNULL(SUM(P.ProductRevenue), 0) AS TotalRevenue, -- Tổng doanh thu
            CASE 
                WHEN T.TicketRevenue > 0 THEN T.TicketRevenue * @LoiNhuanVe -- Giả định lợi nhuận vé là 70% doanh thu
                ELSE 0
            END +
            CASE 
                WHEN SUM(P.ProductRevenue) > 0 THEN SUM(P.ProductRevenue) * @LoiNhuanSanPham -- Giả định lợi nhuận sản phẩm là 50% doanh thu
                ELSE 0
            END AS TotalProfit -- Tổng lợi nhuận
        FROM TicketData T
        LEFT JOIN ProductData P ON T.MovieID = P.ProductID -- Kết nối qua ID phim
        GROUP BY T.MovieID, T.MovieName, T.TicketCount, T.TicketRevenue
    )

    -- Truy vấn cuối cùng
    SELECT 
        MovieID,
        MovieName,
        TicketCount,
        TicketRevenue,
        TotalProductCount AS ProductCount,
        TotalProductRevenue AS ProductRevenue,
        TotalRevenue,
        TotalProfit
    FROM CombinedData
    ORDER BY MovieName ASC;
END;
