using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_DM_Theater_DTO
    {
        private long? autoID;
        private string name;
        private int status;
        private int deleted;

        public tbl_DM_Theater_DTO(long? autoID, string name, int status, int deleted)
        {
            this.autoID = autoID;
            this.name = name;
            this.status = status;
            this.deleted = deleted;
        }

        public long? AutoID { get => autoID; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public int Deleted { 
            get => deleted; 
            set{
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
    }
}
