
-- Thêm một vài bộ phim vào bảng tbl_DM_Movie
INSERT INTO tbl_DM_Movie (MV_NAME, MV_PRICE, MV_DURATION, MV_POSTERURL, MV_DESCRIPTION, MV_AGERATING_AutoID, DELETED, CREATED)
VALUES 
('Inception', 100000, 148, 'inception.jpg', 'A sci-fi thriller about dreams within dreams', NULL, 0, GETDATE()),
('The Matrix', 90000, 136, 'matrix.jpg', 'A hacker discovers reality is a simulation', NULL, 0, GETDATE()),
('Interstellar', 120000, 169, 'interstellar.jpg', 'A journey through space and time to save humanity', NULL, 0, GETDATE());

-- Thêm dữ liệu vào bảng tbl_DM_Theater (rạp chiếu phim)
INSERT INTO tbl_DM_Theater (TT_NAME, TT_STATUS, DELETED, CREATED)
VALUES 
('Theater 1', 1, 0, GETDATE()),
('Theater 2', 1, 0, GETDATE());

-- Thêm dữ liệu vào bảng tbl_DM_MovieSchedule (lịch chiếu phim)
INSERT INTO tbl_DM_MovieSchedule (MS_MOVIE_AutoID, MS_THEATER_AutoID, MS_START, DELETED, CREATED)
VALUES
(1, 1, '2024-10-22 10:00:00', 0, GETDATE()),  -- Inception tại Theater 1
(2, 2, '2024-10-22 13:00:00', 0, GETDATE()),  -- The Matrix tại Theater 2
(3, 1, '2024-10-22 16:00:00', 0, GETDATE());  -- Interstellar tại Theater 1

-- Thêm dữ liệu vào bảng tbl_DM_Staff (nhân viên)
INSERT INTO tbl_DM_Staff (ST_USERNAME, ST_PASSWORD, ST_NAME, ST_PHONE, ST_CIC, ST_NOTE, ST_LEVEL, DELETED, CREATED)
VALUES
('staff1', 'password1', 'John Doe', '0123456789', '123456789012', 'Nhân viên bán vé', 1, 0, GETDATE()),
('staff2', 'password2', 'Jane Smith', '0987654321', '987654321012', 'Nhân viên bán vé', 1, 0, GETDATE());

-- them ghe
insert into tbl_DM_Seat (SE_FILE, SE_RANK, SE_THEATER_AutoID, DELETED, CREATED)
values
('A', 1, 1, 0, GETDATE()),
('A', 2, 1, 0, GETDATE()),
('B', 1, 1, 0, GETDATE()),
('B', 2, 1, 0, GETDATE()),
('C', 1, 1, 0, GETDATE()),
('C', 2, 1, 0, GETDATE())


-- Thêm dữ liệu vào bảng tbl_DM_Ticket (vé)
INSERT INTO tbl_DM_Ticket (TK_SEAT_AutoID, TK_MOVIESCHEDULE_AutoID, TK_STAFF_AutoID, TK_PRICE, DELETED, CREATED)
VALUES
(1, 1, 1, 100000, 0, GETDATE()),  -- Vé cho phim Inception
(2, 1, 1, 100000, 0, GETDATE()),  -- Vé cho phim Inception
(3, 2, 2, 90000, 0, GETDATE()),   -- Vé cho phim The Matrix
(4, 3, 1, 120000, 0, GETDATE());  -- Vé cho phim Interstellar


INSERT INTO [dbo].[tbl_DM_Staff] ([ST_USERNAME] ,[ST_PASSWORD] ,[ST_NAME] 
,[ST_PHONE] ,[ST_CIC] ,[ST_NOTE] ,[ST_LEVEL] ,[DELETED] ,[CREATED] 
,[CREATED_BY] ,[CREATED_BY_FUNCTION] ,[UPDATED] ,[UPDATED_BY] ,[UPDATED_BY_FUNCTION])
VALUES ('admin' ,'c4ca4238a0b923820dcc509a6f75849b' ,'Admin User' 
,'0123456789' ,'123456789012' ,'Admin account' ,-5 ,0
,GETDATE() ,'admin' ,'System' ,GETDATE() ,'admin' ,'System') 
GO