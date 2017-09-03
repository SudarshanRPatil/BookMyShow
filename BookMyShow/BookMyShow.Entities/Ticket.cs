using System;

namespace BookMyShow.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Seat Seat { get; set; }

        public string ScreenNumber { get; set; }

        public DateTime ShowTime { get; set; }

        public string TheatreId { get; set; }

        public Money Price { get; set; }
    }
}