namespace Core.Models
{
    public class Cargo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Type { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
    }
}
