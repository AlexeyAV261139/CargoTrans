namespace DataAccess.Postgres.Models
{
    public class FlightEntity
    {
        public Guid Id { get; set; }

        public Guid PathId { get; set; }

        public Guid DriverId {  get; set; }

        public Guid CarId { get; set; }

        public Guid CargoId { get; set; }

        public DateTime Deadline { get; set; }

        public PathEntity? Path { get; set; }

        public DriverEntity? Driver { get; set; }

        public CarEntity? Car { get; set;}

        public CargoEntity? Cargo {  get; set; } 
    }
}
