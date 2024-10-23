--Đây là user admin để đăng nhập vào hệ thống
USE [CM_Cinema_DB]
GO

INSERT INTO [dbo].[tbl_DM_Staff]
           ([ST_USERNAME]
           ,[ST_PASSWORD]
           ,[ST_NAME]
           ,[ST_PHONE]
           ,[ST_CIC]
           ,[ST_NOTE]
           ,[ST_LEVEL]
           ,[DELETED]
           ,[CREATED]
           ,[CREATED_BY]
           ,[CREATED_BY_FUNCTION]
           ,[UPDATED]
           ,[UPDATED_BY]
           ,[UPDATED_BY_FUNCTION])
     VALUES
           ('admin' 
           ,'c4ca4238a0b923820dcc509a6f75849b'
           ,'Admin User' 
           ,'0123456789' 
           ,'123456789012'  
           ,'Admin account' 
           ,-5  
           ,0  
           ,GETDATE() 
           ,'admin'
           ,'System' 
           ,GETDATE() 
           ,'admin' 
           ,'System') 
GO
