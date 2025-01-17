﻿namespace DTO.tbl_DTO
{
    public class TicketItem_DTO
    {
        private long _ID;
        private string _MovieName;
        private string _SeatName;
        private string _TheaterName;
        private double _Price;

        public TicketItem_DTO(long iD, string movieName, string seatName, string theaterName, double price)
        {
            _ID = iD;
            MovieName = movieName;
            SeatName = seatName;
            TheaterName = theaterName;
            Price = price;
        }

        public long ID { get => _ID; }
        public string MovieName { get => _MovieName; set => _MovieName = value; }
        public string SeatName { get => _SeatName; set => _SeatName = value; }
        public string TheaterName { get => _TheaterName; set => _TheaterName = value; }
        public double Price { get => _Price; set => _Price = value; }
    }
}
