namespace DataAccess.Postgres.Models
{
    public class DriverEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateOnly Birthday { get; set; }

        public List<FlightEntity> Flights { get; set; } = [];
    }
}
