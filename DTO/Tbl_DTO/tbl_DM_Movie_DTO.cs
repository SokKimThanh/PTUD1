using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục phim
    /// </summary>
    public class tbl_DM_Movie_DTO
    {
        private long mV_AutoID;
        private string mV_NAME, mV_POSTERURL, mV_DESCRIPTION;
        private double mV_PRICE;
        private int mV_DURATION;

        public tbl_DM_Movie_DTO()
        {
        }

        public tbl_DM_Movie_DTO(string mV_NAME, string mV_POSTERURL, string mV_DESCRIPTION, double mV_PRICE, int mV_DURATION, long mV_AutoID)
        {
            this.mV_NAME = mV_NAME;
            this.mV_POSTERURL = mV_POSTERURL;
            this.mV_DESCRIPTION = mV_DESCRIPTION;
            this.mV_PRICE = mV_PRICE;
            this.mV_DURATION = mV_DURATION;
            this.mV_AutoID = mV_AutoID;
        }

        public string MV_NAME { get => mV_NAME; set => mV_NAME = value; }
        public string MV_POSTERURL { get => mV_POSTERURL; set => mV_POSTERURL = value; }
        public string MV_DESCRIPTION { get => mV_DESCRIPTION; set => mV_DESCRIPTION = value; }
        public double MV_PRICE { get => mV_PRICE; set => mV_PRICE = value; }
        public int MV_DURATION { get => mV_DURATION; set => mV_DURATION = value; }
        public long MV_AutoID { get => mV_AutoID; set => mV_AutoID = value; }
    }
}
