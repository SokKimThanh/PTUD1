GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <17/11/2024>
-- Description:	<Báo cáo doanh thu vé và sản phẩm>
-- =============================================
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

-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <22/10/2024>
-- Description:	<Tồn kho và chi phí>
-- =============================================
go
drop proc if exists sp_TonKhoChiTiet
drop proc if exists sp_TonKhoTongQuan
go
CREATE PROCEDURE sp_TonKhoChiTiet
    @StartDate DATETIME,                     -- Ngày bắt đầu
    @EndDate DATETIME,                       -- Ngày kết thúc
    @SalesPerformanceThreshold INT = 50,     -- Ngưỡng hiệu suất bán hàng (mặc định 50%)
    @MinStockThreshold INT = 50,             -- Lượng tồn kho dưới ngưỡng tối thiểu (mặc định 50%)
    @DesiredProfitMargin FLOAT = 0.2         -- Lợi nhuận mong muốn (20%)
AS
BEGIN
    SET NOCOUNT ON;

    -- CTE cho số liệu nhập hàng
    WITH Received AS (
        SELECT 
            EX.EX_EXTYPE_AutoID AS ProductID,
            SUM(EX.EX_QUANTITY) AS TotalReceived, -- Tổng số lượng nhập
            SUM(EX.EX_PRICE) AS TotalImportCost,  -- Tổng chi phí nhập
            CASE 
                WHEN SUM(EX.EX_QUANTITY) > 0 THEN SUM(EX.EX_PRICE) / SUM(EX.EX_QUANTITY) 
                ELSE 0 
            END AS UnitCost -- Giá gốc đơn vị
        FROM tbl_SYS_Expense EX
        WHERE EX.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY EX.EX_EXTYPE_AutoID
    ),
    -- CTE cho số liệu bán vé (Nhóm theo phim)
    TicketRevenue AS (
        SELECT 
            MV.MV_AutoID AS MovieID,              -- Mã phim
            MV.MV_NAME AS MovieName,              -- Tên phim
            MV.MV_PRICE AS TicketPrice,           -- Giá vé
            COUNT(TK.TK_AutoID) AS TotalTickets,  -- Tổng số lượng vé
            COUNT(TK.TK_AutoID) * MV.MV_PRICE AS TotalTicketRevenue -- Tổng doanh thu vé
        FROM tbl_DM_Ticket TK
        INNER JOIN tbl_DM_Movie MV ON TK.TK_MOVIESCHEDULE_AutoID = MV.MV_AutoID
        WHERE TK.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY MV.MV_AutoID, MV.MV_NAME, MV.MV_PRICE
    ),
    -- CTE cho số liệu bán hàng (sản phẩm)
    Sold AS (
        SELECT 
            BD.BD_PRODUCT_AutoID AS ProductID,
            SUM(BD.BD_QUANTITY) AS TotalSold,                       -- Tổng số lượng bán sản phẩm
            SUM(BD.BD_QUANTITY * P.PD_PRICE) AS ProductRevenue,     -- Doanh thu từ sản phẩm
            P.PD_PRICE AS UnitPrice                                -- Giá bán đơn vị sản phẩm
        FROM tbl_DM_BillDetail BD
        INNER JOIN tbl_DM_Bill B ON BD.BD_BILL_AutoID = B.BL_AutoID
        INNER JOIN tbl_DM_Product P ON BD.BD_PRODUCT_AutoID = P.PD_AutoID
        WHERE B.CREATED BETWEEN @StartDate AND @EndDate
        GROUP BY BD.BD_PRODUCT_AutoID, P.PD_PRICE
    )
    -- Truy vấn chính
    SELECT 
        PD.PD_AutoID AS ProductID,
        PD.PD_NAME AS ProductName,
        ISNULL(R.TotalReceived, 0) AS ReceivedQuantity,             -- Số lượng nhập
        ISNULL(R.TotalImportCost, 0) AS TotalImportCost,            -- Tổng chi phí nhập
        ISNULL(R.UnitCost, 0) AS UnitCost,                          -- Giá gốc đơn vị
        ISNULL(S.TotalSold, 0) AS SoldQuantity,                     -- Số lượng bán sản phẩm
        ISNULL(S.UnitPrice, 0) AS UnitPrice,                        -- Giá bán đơn vị sản phẩm
        ISNULL(S.ProductRevenue, 0) + ISNULL(TR.TotalTicketRevenue, 0) AS TotalRevenue, -- Tổng doanh thu
        CASE 
            WHEN ISNULL(R.UnitCost, 0) > 0 THEN 
                ISNULL(S.ProductRevenue, 0) - ISNULL(R.UnitCost, 0) * ISNULL(S.TotalSold, 0) + ISNULL(TR.TotalTicketRevenue, 0)
            ELSE ISNULL(TR.TotalTicketRevenue, 0)
        END AS ProfitLoss,                                          -- Lợi nhuận
        CASE 
			WHEN ISNULL(R.TotalReceived, 0) = 0 THEN 0
			ELSE ROUND(ISNULL(S.TotalSold, 0) * 100.0 / ISNULL(R.TotalReceived, 0), 2)
		END AS SalesPerformancePercentage,                         -- Hiệu suất bán hàng (%)
        CASE 
            WHEN ISNULL(R.TotalReceived, 0) = 0 THEN N'Cần nhập hàng'
            WHEN (ISNULL(S.TotalSold, 0) * 100.0 / ISNULL(R.TotalReceived, 0)) < @SalesPerformanceThreshold THEN N'Bán chậm'
            ELSE N'Hiệu suất cao'
        END AS SalesPerformanceCategory,                           -- Phân loại hiệu suất
        CASE 
            WHEN (ISNULL(R.TotalReceived, 0) - ISNULL(S.TotalSold, 0)) < @MinStockThreshold THEN N'Cần nhập hàng'
            ELSE N'Đủ hàng'
        END AS RestockStatus,                                      -- Cảnh báo thiếu hàng
        CASE 
            WHEN ISNULL(S.TotalSold, 0) = 0 AND R.TotalReceived > 0 THEN N'Tồn lâu'
            ELSE N'Bình thường'
        END AS InventoryAgeStatus,                                 -- Sản phẩm tồn kho lâu ngày
        CASE 
            WHEN ISNULL(S.ProductRevenue, 0) - ISNULL(R.UnitCost, 0) * ISNULL(S.TotalSold, 0) < 0 
            THEN ROUND(ISNULL(R.UnitCost, 0) * (1 + @DesiredProfitMargin), 0)
            ELSE NULL
        END AS SuggestedPrice                                      -- Giá bán đề xuất khi bán lỗ
    FROM tbl_DM_Product PD
    LEFT JOIN Received R ON PD.PD_AutoID = R.ProductID
    LEFT JOIN Sold S ON PD.PD_AutoID = S.ProductID
    LEFT JOIN TicketRevenue TR ON TR.MovieID = PD.PD_AutoID
    WHERE PD.DELETED = 0
    ORDER BY PD.PD_NAME ASC;
END;



go
CREATE PROCEDURE sp_TonKhoTongQuan
    @StartDate DATETIME,                  -- Ngày bắt đầu
    @EndDate DATETIME,                    -- Ngày kết thúc
    @SalesPerformanceThreshold INT = 50   -- Ngưỡng phần trăm hiệu suất bán hàng (mặc định 50%)
AS
BEGIN
    SET NOCOUNT ON;

    -- Truy vấn lấy dữ liệu báo cáo
    SELECT 
        PD.PD_AutoID AS ProductID,
        PD.PD_NAME AS ProductName,

        -- Tính tổng số lượng nhập
        ISNULL(SUM(EX.EX_QUANTITY), 0) AS TotalReceived,

        -- Tính tổng số lượng bán
        ISNULL(SUM(BD.BD_QUANTITY), 0) AS TotalSold,

        -- Tính hiệu suất bán hàng (%)
        CASE 
            WHEN ISNULL(SUM(EX.EX_QUANTITY), 0) = 0 THEN 0  -- Tránh chia cho 0
            ELSE (ISNULL(SUM(BD.BD_QUANTITY), 0) * 100.0 / ISNULL(SUM(EX.EX_QUANTITY), 0))
        END AS SalesPerformancePercentage,

        -- Phân loại hiệu suất bán hàng
        CASE
            WHEN ISNULL(SUM(EX.EX_QUANTITY), 0) = 0 THEN N'Cần nhập hàng'
            WHEN (ISNULL(SUM(BD.BD_QUANTITY), 0) * 100.0 / ISNULL(SUM(EX.EX_QUANTITY), 0)) < @SalesPerformanceThreshold THEN N'Bán chậm'
            WHEN (ISNULL(SUM(BD.BD_QUANTITY), 0) * 100.0 / ISNULL(SUM(EX.EX_QUANTITY), 0)) BETWEEN @SalesPerformanceThreshold AND (@SalesPerformanceThreshold + 20) THEN N'Hiệu suất ổn định'
            ELSE N'Mặt hàng hot'
        END AS SalesPerformanceCategory

    FROM tbl_DM_Product PD
    LEFT JOIN tbl_SYS_Expense EX ON EX.EX_EXTYPE_AutoID = PD.PD_AutoID AND EX.CREATED BETWEEN @StartDate AND @EndDate
    LEFT JOIN tbl_DM_BillDetail BD ON BD.BD_PRODUCT_AutoID = PD.PD_AutoID AND BD.CREATED BETWEEN @StartDate AND @EndDate
    WHERE PD.DELETED = 0
    GROUP BY PD.PD_AutoID, PD.PD_NAME
    ORDER BY PD.PD_NAME ASC;
END;
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


-- Store Proceduces
-- In vé
go
DROP PROCEDURE IF EXISTS sp_PrintTicket;

go
CREATE PROCEDURE sp_PrintTicket
    @TicketID BIGINT
AS
BEGIN
    SELECT 
        t.TK_AutoID AS TicketID,
        t.TK_SEATNAME AS SeatName,
        m.MV_NAME AS MovieName,
        th.TT_NAME AS TheaterName,
        CONVERT(DATE, ms.MS_START) AS StartDate,
        CONVERT(TIME, ms.MS_START) AS StartTime,
		m.MV_PRICE AS Price,
        s.ST_NAME AS StaffName,
        m.MV_DURATION AS Duration
    FROM 
        tbl_DM_Ticket t
    JOIN 
        tbl_DM_MovieSchedule ms ON t.TK_MOVIESCHEDULE_AutoID = ms.MS_AutoID
    JOIN 
        tbl_DM_Movie m ON ms.MS_MOVIE_AutoID = m.MV_AutoID
    JOIN 
        tbl_DM_Theater th ON ms.MS_THEATER_AutoID = th.TT_AutoID
    JOIN 
        tbl_DM_Staff s ON t.TK_STAFF_AutoID = s.ST_AutoID
    WHERE 
        t.TK_AutoID = @TicketID;
END;

-- In hóa đơn
go
drop proc if exists sp_HoaDon_BaoCao
go
CREATE PROCEDURE sp_HoaDon_BaoCao
@Bill_AutoID bigint
as
Begin

	select bl.BL_AutoID as AutoID, count(tk.TK_AutoID) as NoTicket, bl.CREATED as Created, st.ST_NAME as StaffName, bl.BL_Trang_Thai_ID as BillStatus,
		pd.PD_NAME as ProductName, bd.BD_QUANTITY as Quantity, pd.PD_PRICE as BasePrice, bd.BD_QUANTITY * pd.PD_PRICE as TotalPrice 
	from tbl_DM_Bill as bl
	join tbl_DM_BillDetail as bd on bl.BL_AutoID = bd.BD_BILL_AutoID
	join tbl_DM_Ticket as tk on bl.BL_AutoID = TK_BILL_AutoID
	join tbl_DM_Staff as st on bl.BL_STAFF_AutoID = st.ST_AutoID
	join tbl_DM_Product as pd on bd.BD_PRODUCT_AutoID = pd.PD_AutoID
	where bl.BL_AutoID = @Bill_AutoID
	group by bl.BL_AutoID, bl.CREATED, st.ST_NAME , bl.BL_Trang_Thai_ID ,
		pd.PD_NAME , bd.BD_QUANTITY , pd.PD_PRICE , bd.BD_QUANTITY * pd.PD_PRICE
End