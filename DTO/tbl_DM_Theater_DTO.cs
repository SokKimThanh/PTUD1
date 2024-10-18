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

        public tbl_DM_Theater_DTO(long? autoID, string name, int status)
        {
            this.autoID = autoID;
            this.name = name;
            this.status = status;
        }

        public long? AutoID { get => autoID; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
    }
}
