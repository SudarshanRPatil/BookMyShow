using System.Collections.Generic;

namespace BookMyShow.Entities
{
    public class Show
    {
        public Duration Duration { get; set; }

        public int AuditoriumId { get; set; }

        public string TheatreId { get; set; }

        public Duration Interval { get; set; }

        public List<SeatInfo> Rates { get; set; }

        public string Language { get; set; }
    }
}