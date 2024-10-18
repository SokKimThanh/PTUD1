go
use master

go
drop database if exists CM_Cinema_DB

go
create database CM_Cinema_DB

go
use CM_Cinema_DB

go
create table tbl_DM_Seat(
SE_AutoID bigint primary key IDENTITY(1,1) not null,
SE_FILE nchar(2) not null,
SE_RANK int not null,
SE_THEATER_AutoID bigint not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
-- Bảng phân loại độ tuổi
-- Xếp loại độ tuổi phù hợp để xem 1 phim bất kỳ
create table tbl_DM_AgeRating(
AR_AutoID bigint primary key IDENTITY(1,1) not null,
AR_NAME nvarchar(150) not null,
AR_NOTE nvarchar(MAX),
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
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
MV_POSTERURL text not null,
MV_DESCRIPTION nvarchar(MAX) not null,
MV_AGERATING_AutoID bigint,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
-- Bảng phòng xem phim
-- Quản lý các thông tin của phòng xem phim (VD: số lượng ghế, tên phòng)
create table tbl_DM_Theater(
TT_AutoID bigint primary key IDENTITY(1,1) not null,
TT_NAME nvarchar(250) not null,
TT_STATUS int not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
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
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
-- Bảng vé
-- Quản lý thông tin của các vé được bán ra (VD: địa chỉ rạp phim, người bán, tên phim, giờ chiếu,...)
create table tbl_DM_Ticket(
TK_AutoID bigint primary key IDENTITY(1,1) not null,
TK_SEATSCHEDULE_AutoID bigint not null,
TK_STAFF_AutoID bigint not null,
TK_PRICE float not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
-- Bảng lịch chiếu phim
-- Quản lý lịch chiếu phim bao gồm tên phim, ngày chiếu, giờ chiếu
create table tbl_DM_MovieSchedule(
MS_AutoID bigint primary key IDENTITY(1,1) not null,
MS_MOVIE_AutoID bigint,
MS_THEATER_AutoID bigint,
MS_START datetime not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
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
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
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
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
-- Bảng ngôn ngữ
-- Quản lý các đoạn văn bản được dịch sang các ngôn ngữ khác nhau
create table tbl_Sys_Language(
Lang_AutoID bigint primary key IDENTITY(1,1) not null,
Eng_Lang nvarchar,
VN_Lang nvarchar,
JP_Lang nvarchar,
KR_Lang nvarchar,
CN_Lang nvarchar,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

--Bảng thức ăn/uống
-- Quản lý thức ăn/uống
go
create table tbl_DM_Product(
PD_AutoID bigint primary key IDENTITY(1,1) not null,
PD_NAME nvarchar(250) not null,
PD_QUANTITY float not null,
PD_PRICE float not null,
PD_IMAGEURL text not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
create table tbl_DM_Bill(
BL_AutoID bigint primary key IDENTITY(1,1) not null,
BL_PRODUCT_AutoID bigint not null,
BL_QUANTITY float not null,
BL_PRICE float not null,
BL_STAFF_AutoID bigint not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
create table tbl_DM_SeatSchedule(
SES_AutoID bigint primary key IDENTITY(1,1) not null,
SES_MOVIESCHEDULE_AutoID bigint not null,
SES_SEAT_AutoID bigint not null,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

go
create table tbl_DM_ExpenseType(
ET_AutoID bigint primary key IDENTITY(1,1) not null,
ET_NAME nvarchar(50) not null,
ET_PRODUCT_AutoID bigint,
DELETED INT,
CREATED datetime,
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
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
CREATED_BY nchar(30),
CREATED_BY_FUNCTION nchar(250),
UPDATED datetime, 
UPDATED_BY nchar(30),
UPDATED_BY_FUNCTION nchar(200)
)

--
-- Khoá ngoại (optional)
--
go 
alter table tbl_DM_Movie
add constraint fk_movie_rating foreign key (MV_AGERATING_AutoID) references tbl_DM_AgeRating(AR_AutoID)
go 
alter table tbl_DM_Seat
add constraint fk_seat_theater foreign key (SE_THEATER_AutoID) references tbl_DM_Theater(TT_AutoID)
go
alter table tbl_DM_MovieSchedule
add constraint fk_movie_movieschedule foreign key (MS_MOVIE_AutoID) references tbl_DM_Movie(MV_AutoID)
go
alter table tbl_DM_MovieSchedule
add constraint fk_theater_movieschedule foreign key (MS_THEATER_AutoID) references tbl_DM_Theater(TT_AutoID)
go
alter table tbl_DM_Ticket
add constraint fk_ticket_seatschedule foreign key (TK_SEATSCHEDULE_AutoID) references tbl_DM_SeatSchedule(SES_AutoID)
go
alter table tbl_DM_Ticket
add constraint fk_ticket_staff foreign key (TK_STAFF_AutoID) references tbl_DM_Staff(ST_AutoID)
go
alter table tbl_DM_StaffSchedule
add constraint fk_staff_schedule foreign key (SS_STAFF_AutoID) references tbl_DM_Staff(ST_AutoID)
go
alter table tbl_DM_StaffSchedule
add constraint fk_shift_schedule foreign key (SS_SHIFT_AutoID) references tbl_DM_Shift(SF_AutoID)
go
alter table tbl_DM_SeatSchedule
add constraint fk_seat_seatschedule foreign key (SES_SEAT_AutoID) references tbl_DM_Seat(SE_AutoID)
go
alter table tbl_DM_SeatSchedule
add constraint fk_movieschedule_seatschedule foreign key (SES_MOVIESCHEDULE_AutoID) references tbl_DM_MovieSchedule(MS_AutoID)
go
alter table tbl_DM_Bill
add constraint fk_bill_product foreign key (BL_PRODUCT_AutoID) references tbl_DM_Product(PD_AutoID)
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
go
alter table tbl_DM_AgeRating
add constraint uq_agerating unique (AR_NAME)
go
alter table tbl_DM_Movie
add constraint uq_movie unique (MV_NAME, MV_PRICE, MV_DURATION)
go
alter table tbl_DM_ExpenseType
add constraint uq_expensetype unique (ET_NAME)