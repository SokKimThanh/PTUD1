using System;

namespace DTO
{
    public class tbl_DM_Theater_DTO
    {
        private long? autoID;
        private string name;
        private int status;
        private int rows;
        private int columns;
        private int couples;
        private int deleted;

        public tbl_DM_Theater_DTO(long? autoID, string name, int status, int rows, int columns, int couples, int deleted)
        {
            this.autoID = autoID;
            this.Name = name;
            this.Status = status;
            this.Rows = rows;
            this.Couples = couples;
            this.Columns = columns;
            this.Deleted = deleted;
        }

        public long? AutoID { get => autoID; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int Deleted
        {
            get => deleted;
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new Exception("Lỗi nhập dữ liệu (DELETED");
                }
                else
                {
                    this.deleted = value;
                }
            }
        }

        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public int Couples { get => couples; set => couples = value; }
    }
}
