DELETE FROM tbl_DM_AgeRating;

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
