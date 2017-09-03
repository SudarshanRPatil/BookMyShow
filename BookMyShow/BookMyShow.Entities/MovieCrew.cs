using System.Collections.Generic;

namespace BookMyShow.Entities
{
    public class MovieCrew
    {
        public List<Director> Directors { get; set; }

        public List<Producer> Producers { get; set; }
    }
}