namespace DataAccess.Postgres.Models
{
    public class PathEntity
    {
        public Guid Id { get; set; }

        public string Destination { get; set; } = string.Empty;

        public int Distance { get; set; }

        public decimal Price { get; set; } = 0;

        public List<FlightEntity> Flights { get; set; } = [];
    }
}
