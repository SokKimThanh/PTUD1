go
use master

go
drop database if exists CM_Cinema_DB

go
create database CM_Cinema_DB

go
use CM_Cinema_DB

go
-- Bảng phân loại độ tuổi
-- Xếp loại độ tuổi phù hợp để xem 1 phim bất kỳ
create table tbl_DM_AgeRating(
AR_AutoID bigint primary key IDENTITY(1,1) not null,
AR_NAME nvarchar(150) not null,
AR_NOTE nvarchar(MAX),
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng phim
-- Quản lý các thông tin của các bộ phim có tại hệ thống
-- Thời lượng được tính bằng phút
create table tbl_DM_Movie(
MV_AutoID bigint primary key IDENTITY(1,1) not null,
MV_NAME nvarchar(250) not null,
MV_PRICE float not null,
MV_DURATION int not null,
MV_POSTERURL nvarchar(MAX) not null,
MV_DESCRIPTION nvarchar(MAX) not null,
MV_AGERATING_AutoID bigint,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng phòng xem phim
-- Quản lý các thông tin của phòng xem phim (VD: số lượng ghế, tên phòng)
create table tbl_DM_Theater(
TT_AutoID bigint primary key IDENTITY(1,1) not null,
TT_NAME nvarchar(250) not null,
TT_STATUS int not null,
TT_ROWS int not null,
TT_COLS int not null,
TT_COUPLES int not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go 
-- Bảng nhân viên
-- Quản lý thông tin của các nhân viên làm việc tại hệ thống
create table tbl_DM_Staff(
ST_AutoID bigint primary key IDENTITY(1,1) not null,
ST_USERNAME nchar(50) not null,
ST_PASSWORD nchar(200) not null,
ST_NAME nvarchar(250) not null,
ST_PHONE char(10) not null,
ST_CIC char(12) not null,
ST_NOTE nvarchar(MAX),
ST_LEVEL int not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng vé
-- Quản lý thông tin của các vé được bán ra (VD: địa chỉ rạp phim, người bán, tên phim, giờ chiếu,...)
create table tbl_DM_Ticket(
TK_AutoID bigint primary key IDENTITY(1,1) not null,
TK_SEATNAME nchar(3) not null,
TK_MOVIESCHEDULE_AutoID bigint not null,
TK_STAFF_AutoID bigint not null,
TK_BILL_AutoID bigint,
TK_STATUS int not null,
DELETED int,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng lịch chiếu phim
-- Quản lý lịch chiếu phim bao gồm tên phim, ngày chiếu, giờ chiếu
create table tbl_DM_MovieSchedule(
MS_AutoID bigint primary key IDENTITY(1,1) not null,
MS_MOVIE_AutoID bigint not null,
MS_THEATER_AutoID bigint not null,
MS_START datetime not null,
MS_END datetime not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng ca làm
-- Quản lý các ca làm hiện có tại hệ thống
create table tbl_DM_Shift(
SF_AutoID bigint primary key IDENTITY(1,1) not null,
SF_NAME nvarchar(150) not null,
SF_START datetime not null,
SF_END datetime not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng phân công cho nhân viên
-- Quản lý lịch làm việc của nhân viên tại hệ thống
create table tbl_DM_StaffSchedule(
SS_AutoID bigint primary key IDENTITY(1,1) not null,
SS_STAFF_AutoID bigint,
SS_SHIFT_AutoID bigint,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
-- Bảng ngôn ngữ
-- Quản lý các đoạn văn bản được dịch sang các ngôn ngữ khác nhau
create table tbl_Sys_Language(
   Lang_AutoID bigint primary key IDENTITY(1,1) not null,
   Eng_Lang nvarchar(255), 
   VN_Lang nvarchar(255),
   JP_Lang nvarchar(255),
   KR_Lang nvarchar(255),
   CN_Lang nvarchar(255),
   DELETED INT,
   CREATED datetime,
   CREATED_BY nchar(50),
   CREATED_BY_FUNCTION nchar(100),
   UPDATED datetime, 
   UPDATED_BY nchar(50),
   UPDATED_BY_FUNCTION nchar(100)
);

--Bảng thức ăn/uống
-- Quản lý thức ăn/uống
go
create table tbl_DM_Product(
PD_AutoID bigint primary key IDENTITY(1,1) not null,
PD_NAME nvarchar(250) not null,
PD_QUANTITY float not null,
PD_PRICE float not null,
PD_IMAGEURL nvarchar(MAX) not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
create table tbl_DM_Bill(
BL_AutoID bigint primary key IDENTITY(1,1) not null,
BL_STAFF_AutoID bigint not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
create table tbl_DM_BillDetail(
BD_AutoID bigint primary key IDENTITY(1,1) not null,
BD_BILL_AutoID bigint not null,
BD_PRODUCT_AutoID bigint not null,
BD_QUANTITY int not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
create table tbl_DM_ExpenseType(
ET_AutoID bigint primary key IDENTITY(1,1) not null,
ET_NAME nvarchar(50) not null,
ET_PRODUCT_AutoID bigint,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

go
create table tbl_SYS_Expense(
EX_AutoID bigint primary key IDENTITY(1,1) not null,
EX_EXTYPE_AutoID bigint not null,
EX_QUANTITY float not null,
EX_PRICE float not null,
EX_REASON nvarchar(100) not null,
EX_STATUS int,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(50),
CREATED_BY_FUNCTION nchar(100),
UPDATED datetime, 
UPDATED_BY nchar(50),
UPDATED_BY_FUNCTION nchar(100)
)

--
-- Khoá ngoại (optional)
--
go 
alter table tbl_DM_Movie
add constraint fk_movie_rating foreign key (MV_AGERATING_AutoID) references tbl_DM_AgeRating(AR_AutoID)
go 
alter table tbl_DM_BillDetail
add constraint fk_billdetail_bill foreign key (BD_BILL_AutoID) references tbl_DM_Bill(BL_AutoID)
go 
alter table tbl_DM_BillDetail
add constraint fk_billdetail_product foreign key (BD_PRODUCT_AutoID) references tbl_DM_Product(PD_AutoID)
go
alter table tbl_DM_MovieSchedule
add constraint fk_movie_movieschedule foreign key (MS_MOVIE_AutoID) references tbl_DM_Movie(MV_AutoID)
go
alter table tbl_DM_MovieSchedule
add constraint fk_theater_movieschedule foreign key (MS_THEATER_AutoID) references tbl_DM_Theater(TT_AutoID)
go
alter table tbl_DM_Ticket
add constraint fk_ticket_movieschedule foreign key (TK_MOVIESCHEDULE_AutoID) references tbl_DM_MovieSchedule(MS_AutoID)
go
alter table tbl_DM_Ticket
add constraint fk_ticket_staff foreign key (TK_STAFF_AutoID) references tbl_DM_Staff(ST_AutoID)
go
alter table tbl_DM_Ticket
add constraint fk_ticket_bill foreign key (TK_BILL_AutoID) references tbl_DM_Bill(BL_AutoID)
go
alter table tbl_DM_StaffSchedule
add constraint fk_staff_schedule foreign key (SS_STAFF_AutoID) references tbl_DM_Staff(ST_AutoID)
go
alter table tbl_DM_StaffSchedule
add constraint fk_shift_schedule foreign key (SS_SHIFT_AutoID) references tbl_DM_Shift(SF_AutoID)
go
alter table tbl_DM_Bill
add constraint fk_bill_staff foreign key (BL_STAFF_AutoID) references tbl_DM_Staff(ST_AutoID)
go
alter table tbl_DM_ExpenseType
add constraint fk_expensetype_product foreign key (ET_PRODUCT_AutoID) references tbl_DM_Product(PD_AutoID)
go
alter table tbl_SYS_Expense
add constraint fk_expense_expensetype foreign key (EX_EXTYPE_AutoID) references tbl_DM_ExpenseType(ET_AutoID)

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
