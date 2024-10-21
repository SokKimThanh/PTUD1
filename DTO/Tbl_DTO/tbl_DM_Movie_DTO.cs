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
        private long? mV_AGERATING_AutoID; // Có thể null

        public tbl_DM_Movie_DTO()
        {
        }

        public tbl_DM_Movie_DTO(string mV_NAME, string mV_POSTERURL, string mV_DESCRIPTION, double mV_PRICE, int mV_DURATION, long mV_AutoID, long? mV_AGERATING_AutoID = null)
        {
            MV_NAME = mV_NAME;
            MV_POSTERURL = mV_POSTERURL;
            MV_DESCRIPTION = mV_DESCRIPTION;
            MV_PRICE = mV_PRICE;
            MV_DURATION = mV_DURATION;
            MV_AutoID = mV_AutoID;
            this.mV_AGERATING_AutoID = mV_AGERATING_AutoID;
        }

        public string MV_NAME
        {
            get => mV_NAME;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Tên phim không được để trống.");
                if (value.Length > 250)
                    throw new ArgumentException("Tên phim không được vượt quá 250 ký tự.");
                mV_NAME = value;
            }
        }

        public string MV_POSTERURL
        {
            get => mV_POSTERURL;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("URL poster không được để trống.");
                if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
                    throw new ArgumentException("URL poster không hợp lệ.");
                mV_POSTERURL = value;
            }
        }

        public string MV_DESCRIPTION
        {
            get => mV_DESCRIPTION;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Mô tả không được để trống.");
                if (value.Length > 1000)
                    throw new ArgumentException("Mô tả không được vượt quá 1000 ký tự.");
                mV_DESCRIPTION = value;
            }
        }

        public double MV_PRICE
        {
            get => mV_PRICE;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Giá phim phải là số dương.");
                mV_PRICE = value;
            }
        }

        public int MV_DURATION
        {
            get => mV_DURATION;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Thời lượng phim phải là số nguyên dương.");
                mV_DURATION = value;
            }
        }

        public long MV_AutoID
        {
            get => mV_AutoID;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("MV_AutoID không hợp lệ.");
                mV_AutoID = value;
            }
        }
        public long? MV_AGERATING_AutoID { get => mV_AGERATING_AutoID; set => mV_AGERATING_AutoID = value; }

    }
}
