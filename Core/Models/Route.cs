namespace Core.Models
{
    public class Route
    {
        public Guid Id { get; set; }

        public string Destination { get; set; } = string.Empty;

        public int Distance { get; set; }

        public decimal Price { get; set; }
    }
}
