
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
INSERT INTO [dbo].[tbl_DM_Staff] ([ST_USERNAME] ,[ST_PASSWORD] ,[ST_NAME] 
,[ST_PHONE] ,[ST_CIC] ,[ST_NOTE] ,[ST_LEVEL] ,[DELETED] ,[CREATED] 
,[CREATED_BY] ,[CREATED_BY_FUNCTION] ,[UPDATED] ,[UPDATED_BY] ,[UPDATED_BY_FUNCTION])
VALUES 
('admin' ,'c4ca4238a0b923820dcc509a6f75849b' ,'Admin User', '0123456789' ,'123456789012' ,'Admin account' ,-5 , 0, GETDATE() ,'admin' ,'System' ,GETDATE() ,'admin' ,'System'),
('staff1', 'c4ca4238a0b923820dcc509a6f75849b', 'sokkimthanh', '0123456789', '123456789012', 'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff2', 'c4ca4238a0b923820dcc509a6f75849b', 'leduyanhtu', '0987654321', '987654321012', 'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff3', 'c4ca4238a0b923820dcc509a6f75849b', 'tranminhtuan', '0987654321', '987654321012', 'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

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
INSERT INTO tbl_DM_Ticket (TK_SEAT_AutoID, TK_MOVIESCHEDULE_AutoID, TK_STAFF_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
(1, 1, 1,  0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
(2, 1, 1,  0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
(3, 2, 2,  0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Vé cho phim The Matrix
(4, 3, 1,  0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Vé cho phim Interstellar

-- Thêm dữ liệu vào bảng tbl_DM_Shift
INSERT INTO tbl_DM_Shift (SF_NAME, SF_START, SF_END, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
('Shift 1', '08:00:00', '16:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Shift 2', '16:00:00', '23:59:59', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm dữ liệu vào bảng tbl_DM_StaffSchedule
INSERT INTO tbl_DM_StaffSchedule (SS_STAFF_AutoID, SS_SHIFT_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm dữ liệu vào bảng tbl_Sys_Language
INSERT INTO tbl_Sys_Language (Eng_Lang, VN_Lang, JP_Lang, KR_Lang, CN_Lang, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(N'Hello', N'Xin chào', N'こんにちは', N'안녕하세요', N'你好', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Goodbye', N'Tạm biệt', N'さようなら', N'안녕히 가세요', N'再见', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm dữ liệu vào bảng tbl_DM_Product
INSERT INTO tbl_DM_Product (PD_NAME, PD_QUANTITY, PD_PRICE, PD_IMAGEURL, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
('Popcorn', 100, 50.0, 'url_to_popcorn_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Coca-Cola', 200, 20.0, 'url_to_coke_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Fanta', 200, 20.0, 'url_to_fanta_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Sprite', 200, 20.0, 'url_to_sprite_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm dữ liệu vào bảng tbl_DM_Bill
INSERT INTO tbl_DM_Bill (BL_PRODUCT_AutoID, BL_QUANTITY, BL_PRICE, BL_STAFF_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(1, 2, 100.0, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(2, 3, 60.0, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');


INSERT INTO tbl_DM_ExpenseType (ET_NAME, ET_PRODUCT_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION) 
VALUES
-- Loại chi phí khác
(N'Chi phí bảo trì và sửa chữa thiết bị', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Chi phí nguyên liệu
(N'Nhập: Bắp', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Coca-cola', 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Sprite', 3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Fanta', 4, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Các loại chi phí hàng tháng
(N'Chi phí Đá viên', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Chi phí tiền điện', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Chi phí tiền nước', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Ứng lương nhân viên', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Chi phí thuê mặt bằng', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Chi phí khác không cụ thể
(N'Chi phí khác', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

-- Thêm 10 khoản chi phí vào bảng tbl_SYS_Expense
-- Thêm chi phí mặt bằng
INSERT INTO tbl_SYS_Expense (EX_EXTYPE_AutoID, EX_QUANTITY, EX_PRICE, EX_REASON, EX_STATUS, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
(10, 1, 20000000, N'Mặt bằng - khu vực phổ thông', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(10, 1, 50000000, N'Mặt bằng - khu vực trung tâm', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm chi phí thiết kế và thi công phòng chiếu
(11, 1, 200000000, N'Thiết kế và thi công phòng chiếu', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm chi phí nội thất
(11, 1, 80000000, N'Nội thất (bàn ghế, đồ trang trí, quầy pha chế cafe)', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm chi phí vận hành hàng tháng
(11, 1, 5000000, N'Chi phí Internet, điện nước hàng tháng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(9, 1, 7000000, N'Lương nhân viên hàng tháng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm chi phí thiết bị
(11, 1, 50000000, N'Máy chiếu phim', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(11, 1, 90000000, N'Hệ thống âm thanh', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm các chi phí khác
(11, 1, 10000000, N'Chi phí quảng cáo và marketing', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(1, 1, 5000000, N'Chi phí bảo trì và sửa chữa thiết bị', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
--bap
(2, 1, 3000000, N'Nhập hàng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
--cola
(3, 1, 3000000, N'Nhập hàng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
--sprite
(4, 1, 3000000, N'Nhập hàng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
--fanta
(5, 1, 3000000, N'Nhập hàng', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');
