namespace BookMyShow.Entities
{
    public class Auditorium
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public SeatMap SeatMap { get; set; }

    }
}