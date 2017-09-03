using System.Collections.Generic;

namespace BookMyShow.Entities
{
    public class Theatre
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ChainCode { get; set; }

        public List<Auditorium> Auditoriums { get; set; }

        public List<Amenity> Amenities { get; set; }
    }
}