namespace Core.Models
{
    public class ActiveRoute
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string CargoName { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;

        public string DriverName { get; set; } = string.Empty;

        public string CarBrand {  get; set; } = string.Empty;

        public DateTime DeadLine { get; set; }
    }
}
