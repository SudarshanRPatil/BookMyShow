using System.Collections.Generic;

namespace BookMyShow.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Languages { get; set; }

        public Genre Genre { get; set; }

        public int DurationInMinutes { get; set; }

        public string Summary { get; set; }

        public MovieCertificate Certificate { get; set; }

        public MovieCast Cast { get; set; }

        public MovieCrew Crew { get; set; }
    }
}