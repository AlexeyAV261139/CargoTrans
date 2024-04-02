namespace Core.Models
{
    public class Cargo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string Reequipments { get; set; } = string.Empty;

        public required CargoType Type { get; set; }
    }
}
