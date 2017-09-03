using System.Collections.Generic;

namespace BookMyShow.Entities
{
    public class AuditoriumRow
    {
        public string Name { get; set; }

        public List<AuditoriumSpace> Space { get; set; }

    }
}