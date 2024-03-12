namespace DataAccess.Postgres.Models
{
    public class CarEntity
    {
        public Guid Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public int LiftingCapacity { get; set; }

        public List<FlightEntity> Flights { get; set; } = [];
    }
}
