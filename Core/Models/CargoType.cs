namespace Core.Models
{
    public class CargoType
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public override string ToString() => Name;       
    }
}
