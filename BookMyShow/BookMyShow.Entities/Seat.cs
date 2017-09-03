namespace BookMyShow.Entities
{
    public class Seat
    {
        public int Number { get; set; }

        public string Row { get; set; }

        public SeatClass Class { get; set; }
    }
}