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