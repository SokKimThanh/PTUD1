﻿using System;

namespace DTO.tbl_DTO
{
    public class tbl_DM_MovieSchedule_DTO
    {
        #region Fields
        private long? autoID;
        private long movie_AutoID;
        private string movie_Name;
        private long theater_AutoID;
        private string theater_Name;
        private DateTime startDate;
        private DateTime endDate;
        private int deleted;
        #endregion

        public tbl_DM_MovieSchedule_DTO(long? autoID, long movie_AutoID, string movie_Name, long theater_AutoID, string theater_Name, DateTime startDate, DateTime endDate, int deleted)
        {
            this.AutoID = autoID;
            this.Movie_AutoID = movie_AutoID;
            this.Movie_Name = movie_Name;
            this.Theater_AutoID = theater_AutoID;
            this.Theater_Name = theater_Name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Deleted = deleted;
        }

        #region Properties
        public long? AutoID { get => autoID; set => autoID = value; }
        public long Movie_AutoID { get => movie_AutoID; set => movie_AutoID = value; }
        public long Theater_AutoID { get => theater_AutoID; set => theater_AutoID = value; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {

                startDate = value;
            }
        }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int Deleted { get => deleted; set => deleted = value; }
        public string Movie_Name { get => movie_Name; set => movie_Name = value; }
        public string Theater_Name { get => theater_Name; set => theater_Name = value; }
        #endregion
    }
}
