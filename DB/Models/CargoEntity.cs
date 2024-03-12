namespace DataAccess.Postgres.Models
{
    public class CargoEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<FlightEntity> Flights { get; set; } = [];
    }
}
