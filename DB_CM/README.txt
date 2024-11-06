****************Update 06/11/2024:
ADD:
	+ New fields to Theater table (TT_ROWS, TT_COLS and TT_COUPLES)
REMOVE:
	+ Remove Seat table

****************Update 29/10/2024:
MODIFY:
	+ Modify length of CREATED_BY, CREATED_BY_FUNCTION, UPDATED_BY, UPDATED_BY_FUNCTION
	+ Modify length of MV_POSTERURL and PD_IMAGEURL by varchar(MAX)

****************Update 24/10/2024:
ADD:
	+ Add new unique keys for tables

****************Update 22/10/2024:
REMOVE:
	+ Delete table SeatSchedule due to the inconvenients
MODIFY:
	+ Add TK_SEAT_AutoID field to table Ticket for easier access to booked seat
	+ Remove TK_SEATSCHEDULE_AutoID from table Ticket due to the removal of SeatSchedule table

****************Update 18/10/2024:
ADD:
	+ Unique keys for table Movie and ExpenseType
MODIFY:
	+ Remove TK_NAME and TK_MOVIESCHEDUL_AutoID from tbl_DM_Ticket
	+ Add TK_SEATSCHEDULE_AutoID to tbl_DM_Ticket

****************Update 17/10/2024:
MODIFY: 
	Make primary keys auto increment

****************Update 09/10/2024:
MODIFY: 
	Rename database to "DBCM"

****************Update 07/10/2024:
MODIFY: 
	Table Staff: add ST_USERNAME, ST_PASSWORD
	Table Movie: add MV_POSTERURL
	Table Product: add PD_IMAGEURL
REMOVE: 
	Table Member, Table MemberGroup, Table Account

****************Update 30/09/2024:
ADD: 	
	+ Table Expense, ExpenseType, Seat, SeatSchedule, Bill
	+ Table Movie: add "Description" field
REMOVE:	
	Table Department, Table Branch