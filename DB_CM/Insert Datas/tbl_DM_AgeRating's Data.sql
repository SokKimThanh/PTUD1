insert into tbl_DM_AgeRating (AR_NAME, AR_NOTE, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
values ('P', N'Phim được phép phổ biến đến người xem ở mọi độ tuổi',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new'),
	('K', N'Phim được phổ biến đến người xem dưới 13 tuổi và có người bảo hộ đi kèm',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new'),
	('T13', N'Phim được phổ biến đến người xem từ đủ 13 tuổi trở lên (13+)',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new'),
	('T16', N'Phim được phổ biến đến người xem từ đủ 13 tuổi trở lên (16+)',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new'),
	('T18', N'Phim được phổ biến đến người xem từ đủ 13 tuổi trở lên (18+)',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new'),
	('C', N'Phim không được phép phổ biến',0, GETDATE(), 'Admin', 'Add new', GETDATE(), 'Admin', 'Add new')