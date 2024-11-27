/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [BD_AutoID]
      ,[BD_BILL_AutoID]
      ,[BD_PRODUCT_AutoID]
      ,[BD_QUANTITY]
      ,[DELETED]
      ,[CREATED]
      ,[CREATED_BY]
      ,[CREATED_BY_FUNCTION]
      ,[UPDATED]
      ,[UPDATED_BY]
      ,[UPDATED_BY_FUNCTION]
  FROM [CM_Cinema_DB].[dbo].[tbl_DM_BillDetail]

go
drop proc if exists sp_HoaDon_BaoCao
go
CREATE PROCEDURE sp_HoaDon_BaoCao
@Bill_AutoID bigint
as
Begin

	select @Bill_AutoID as AutoID, mv.MV_NAME as MovieName, count(tk.TK_AutoID) as NoTicket, mv.MV_PRICE as TicketPrice, ms.MS_START as BeginTime, ms.MS_END as EndTime, bl.CREATED as Created, st.ST_NAME as StaffName, bl.BL_Trang_Thai_ID as BillStatus,
		pd.PD_NAME as ProductName, bd.BD_QUANTITY as Quantity, pd.PD_PRICE as BasePrice, bd.BD_QUANTITY * pd.PD_PRICE as TotalPrice 
	from tbl_DM_Bill as bl
	join tbl_DM_BillDetail as bd on bl.BL_AutoID = bd.BD_BILL_AutoID
	join tbl_DM_Ticket as tk on bl.BL_AutoID = TK_BILL_AutoID
	join tbl_DM_Staff as st on bl.BL_STAFF_AutoID = st.ST_AutoID
	join tbl_DM_Product as pd on bd.BD_PRODUCT_AutoID = pd.PD_AutoID
	join tbl_DM_MovieSchedule as ms on tk.TK_MOVIESCHEDULE_AutoID = ms.MS_AutoID
	join tbl_DM_Movie as mv on ms.MS_MOVIE_AutoID = MV_AutoID
	where bl.BL_AutoID = @Bill_AutoID
	group by bl.BL_AutoID, bl.CREATED, st.ST_NAME , bl.BL_Trang_Thai_ID ,
		pd.PD_NAME , bd.BD_QUANTITY , pd.PD_PRICE , bd.BD_QUANTITY * pd.PD_PRICE
End

exec sp_HoaDon_BaoCao 2