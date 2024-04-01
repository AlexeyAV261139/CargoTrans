namespace Core.Models
{
    public class Cargo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public required CargoType Type { get; set; }
    }
}
