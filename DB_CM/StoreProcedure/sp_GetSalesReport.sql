SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <22/10/2024>
-- Description:	<Báo cáo doanh thu vé và phim>
-- =============================================
drop procedure if exists sp_GetSalesReport
drop procedure if exists sp_GetDetailedSalesReport

go
CREATE PROCEDURE sp_GetSalesReport
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
        MV.MV_NAME AS MovieName,
        SUM(MV.MV_PRICE) AS TotalRevenue,
        COUNT(TK.TK_AutoID) AS TicketsSold
    FROM tbl_DM_Ticket TK
    INNER JOIN tbl_DM_MovieSchedule MS ON TK.TK_MOVIESCHEDULE_AutoID = MS.MS_AutoID
    INNER JOIN tbl_DM_Movie MV ON MS.MS_MOVIE_AutoID = MV.MV_AutoID
    WHERE TK.CREATED BETWEEN @StartDate AND @EndDate
    AND TK.DELETED = 0
    GROUP BY MV.MV_NAME
    ORDER BY TotalRevenue DESC;
END;



go
CREATE PROCEDURE sp_GetDetailedSalesReport
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    -- Lấy thông tin chi tiết các vé bán được trong khoảng thời gian đã cho
    SELECT 
        MV.MV_NAME AS MovieName,            -- Tên phim
        MS.MS_START AS ShowTime,            -- Thời gian chiếu phim
        MV.MV_PRICE AS TicketPrice,         -- Giá vé
        TK.CREATED AS SaleTime,             -- Thời gian bán vé
        TT.TT_NAME AS TheaterName           -- Tên rạp chiếu phim
    FROM tbl_DM_Ticket TK
    INNER JOIN tbl_DM_MovieSchedule MS ON TK.TK_MOVIESCHEDULE_AutoID = MS.MS_AutoID
    INNER JOIN tbl_DM_Movie MV ON MS.MS_MOVIE_AutoID = MV.MV_AutoID
    INNER JOIN tbl_DM_Theater TT ON MS.MS_THEATER_AutoID = TT.TT_AutoID
    WHERE TK.CREATED BETWEEN @StartDate AND @EndDate
    AND TK.DELETED = 0
    ORDER BY MV.MV_NAME, MS.MS_START, TK.CREATED;
END;

--EXEC sp_GetDetailedSalesReport '2024-01-01', '2024-12-31';
--EXEC sp_GetSalesReport '2024-01-01', '2024-12-31';