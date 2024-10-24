
INSERT INTO tbl_DM_AgeRating (AR_NAME, AR_NOTE, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
-- Phân loại MPAA (Hoa Kỳ)
('G', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_US', N'Khuyến nghị có sự hướng dẫn của cha mẹ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG-13', N'Khuyến nghị cha mẹ hướng dẫn cho trẻ dưới 13 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R', N'Cấm người dưới 17 tuổi trừ khi có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('NC-17', N'Cấm người dưới 17 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại Việt Nam
('P', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('K', N'Khuyến nghị xem có sự hướng dẫn của cha mẹ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C13', N'Cấm khán giả dưới 13 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C16', N'Cấm khán giả dưới 16 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C18', N'Cấm khán giả dưới 18 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại BBFC (Anh Quốc)
('U', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_EN', N'Khuyến nghị cha mẹ hướng dẫn, có thể có một số nội dung không phù hợp với trẻ nhỏ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('12A', N'Trẻ dưới 12 tuổi cần người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('15', N'Cấm khán giả dưới 15 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('18', N'Cấm khán giả dưới 18 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm một vài bộ phim vào bảng tbl_DM_Movie
INSERT INTO tbl_DM_Movie (MV_NAME, MV_PRICE, MV_DURATION, MV_POSTERURL, MV_DESCRIPTION, MV_AGERATING_AutoID,  DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
('Inception', 100000, 148, 'inception.jpg', 'A sci-fi thriller about dreams within dreams', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Matrix', 90000, 136, 'matrix.jpg', 'A hacker discovers reality is a simulation', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Interstellar', 120000, 169, 'interstellar.jpg', 'A journey through space and time to save humanity', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

insert into tbl_DM_Theater (TT_NAME, TT_STATUS, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
values	(N'Rạp 1', 1, 0, GETDATE(), 'Admin', 'insert',GETDATE(),'Admin', 'insert'),
		(N'Rạp 2', 1, 0, GETDATE(), 'Admin', 'insert',GETDATE(),'Admin', 'insert'),
		(N'Rạp 3', 1, 0, GETDATE(), 'Admin', 'insert',GETDATE(),'Admin', 'insert')

-- Thêm dữ liệu vào bảng tbl_DM_MovieSchedule (lịch chiếu phim)
INSERT INTO tbl_DM_MovieSchedule (MS_MOVIE_AutoID, MS_THEATER_AutoID, MS_START, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
(1, 1, '2024-10-22 10:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Inception tại Theater 1
(2, 2, '2024-10-22 13:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- The Matrix tại Theater 2
(3, 1, '2024-10-22 16:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Interstellar tại Theater 1

-- Thêm dữ liệu vào bảng tbl_DM_Staff (nhân viên)
INSERT INTO tbl_DM_Staff (ST_USERNAME, ST_PASSWORD, ST_NAME, ST_PHONE, ST_CIC, ST_NOTE, ST_LEVEL, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
('staff1', 'c4ca4238a0b923820dcc509a6f75849b', 'Sok Kim Thanh', '0123456789', '123456789012', 'Nhân viên bán vé', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff2', 'c4ca4238a0b923820dcc509a6f75849b', 'Le Duy Anh Tu', '0987654321', '987654321012', 'Nhân viên bán vé', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff2', 'c4ca4238a0b923820dcc509a6f75849b', 'Tran Minh Tuan', '0987654321', '987654321012', 'Nhân viên bán vé', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

INSERT INTO [dbo].[tbl_DM_Staff] ([ST_USERNAME] ,[ST_PASSWORD] ,[ST_NAME] 
,[ST_PHONE] ,[ST_CIC] ,[ST_NOTE] ,[ST_LEVEL] ,[DELETED] ,[CREATED] 
,[CREATED_BY] ,[CREATED_BY_FUNCTION] ,[UPDATED] ,[UPDATED_BY] ,[UPDATED_BY_FUNCTION])
VALUES ('admin' ,'c4ca4238a0b923820dcc509a6f75849b' ,'Admin User' 
,'0123456789' ,'123456789012' ,'Admin account' ,-5 ,0
,GETDATE() ,'admin' ,'System' ,GETDATE() ,'admin' ,'System') 
GO

-- them ghe
insert into tbl_DM_Seat (SE_FILE, SE_RANK, SE_THEATER_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
values
('A', 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('A', 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('B', 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('B', 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C', 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C', 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');


-- Thêm dữ liệu vào bảng tbl_DM_Ticket (vé)
INSERT INTO tbl_DM_Ticket (TK_SEAT_AutoID, TK_MOVIESCHEDULE_AutoID, TK_STAFF_AutoID, TK_PRICE, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
(1, 1, 1, 100000, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
(2, 1, 1, 100000, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
(3, 2, 2, 90000, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Vé cho phim The Matrix
(4, 3, 1, 120000, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Vé cho phim Interstellar

