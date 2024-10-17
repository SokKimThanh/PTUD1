using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Seats
    {
        private int? autoID;
        private string file;
        private int rank;
        private int theater_AutoID;

        public DTO_Seats(int? autoID, string file, int rank, int theater_AutoID)
        {
            this.autoID = autoID;
            this.File = file;
            this.Rank = rank;
            this.Theater_AutoID = theater_AutoID;
        }

        public int? AutoID { get => autoID; }
        public string File { 
            get => file; 
            set 
            {
                if (value.Length != 1 || value.Length != 2)
                    throw new Exception();
                else 
                    file = value;
            } 
        }
        public int Rank { get => rank; set => rank = value; }
        public int Theater_AutoID { get => theater_AutoID; set => theater_AutoID = value; }
    }
}
