namespace Core.Models
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Brand { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public int LoadCapacityPerKg { get; set; }       
    }
}
