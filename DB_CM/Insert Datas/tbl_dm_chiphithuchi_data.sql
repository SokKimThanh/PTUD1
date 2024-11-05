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
