namespace Core.Models
{
    public class Driver
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Phone {  get; set; } = string.Empty;         
    }
}
