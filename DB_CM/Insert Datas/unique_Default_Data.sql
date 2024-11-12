
-- Khóa UNIQUE
-- Thêm khóa UNIQUE cho tbl_DM_Movie
go
alter table tbl_DM_Movie
add constraint uq_movie unique (MV_NAME)
 
-- Thêm khóa UNIQUE cho tbl_DM_Theater
go
ALTER TABLE tbl_DM_Theater
-- Tên rạp chiếu phim nên là duy nhất.
ADD CONSTRAINT uq_theater_name UNIQUE (TT_NAME);

-- Thêm khóa UNIQUE cho tbl_DM_Staff
-- Tên đăng nhập nên là duy nhất.
--go
--ALTER TABLE tbl_DM_Staff 
--ADD CONSTRAINT UQ_ST_USERNAME UNIQUE (ST_USERNAME);

-- Số chứng minh thư/căn cước công dân nên là duy nhất.
--ALTER TABLE tbl_DM_Staff 
--ADD CONSTRAINT UQ_ST_CIC UNIQUE (ST_CIC);

-- Thêm khóa UNIQUE cho tbl_DM_Product
--Tên sản phẩm nên là duy nhất.
go
ALTER TABLE tbl_DM_Product
ADD CONSTRAINT uq_product_name UNIQUE (PD_NAME);

-- Thêm khóa UNIQUE cho tbl_DM_MovieSchedule
-- Một bộ phim không thể chiếu cùng lúc ở cùng một rạp.
go
ALTER TABLE tbl_DM_MovieSchedule
ADD CONSTRAINT uq_movieschedule UNIQUE (MS_MOVIE_AutoID, MS_THEATER_AutoID, MS_START);


-- Thêm ràng buộc UNIQUE cho ET_NAME
ALTER TABLE tbl_DM_ExpenseType
ADD CONSTRAINT UC_ET_NAME UNIQUE (ET_NAME);

-- Đặt giá trị mặc định cho ET_PRODUCT_AutoID là NULL (nếu chưa có)
ALTER TABLE tbl_DM_ExpenseType
ADD CONSTRAINT DF_ET_PRODUCT_AutoID DEFAULT NULL FOR ET_PRODUCT_AutoID;

-- Đặt giá trị mặc định và ràng buộc kiểm tra cho EX_QUANTITY
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_EX_QUANTITY DEFAULT 0 FOR EX_QUANTITY;

ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT CHK_EX_QUANTITY CHECK (EX_QUANTITY >= 0);

-- Đặt giá trị mặc định và ràng buộc kiểm tra cho EX_PRICE
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_EX_PRICE DEFAULT 0 FOR EX_PRICE;

ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT CHK_EX_PRICE CHECK (EX_PRICE >= 0);

-- Đặt giá trị mặc định cho EX_REASON là NULL
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_EX_REASON DEFAULT NULL FOR EX_REASON;

-- Đặt giá trị mặc định và ràng buộc kiểm tra cho EX_STATUS
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_EX_STATUS DEFAULT 0 FOR EX_STATUS;

ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT CHK_EX_STATUS CHECK (EX_STATUS BETWEEN 0 AND 3);

-- Đặt giá trị mặc định và ràng buộc kiểm tra cho DELETED
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_DELETED DEFAULT 0 FOR DELETED;

ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT CHK_DELETED CHECK (DELETED IN (0, 1));

-- Đặt giá trị mặc định cho CREATED là thời gian hiện tại
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_CREATED DEFAULT GETDATE() FOR CREATED;

-- Đặt giá trị mặc định cho UPDATED là thời gian hiện tại
ALTER TABLE tbl_SYS_Expense
ADD CONSTRAINT DF_UPDATED DEFAULT GETDATE() FOR UPDATED;
