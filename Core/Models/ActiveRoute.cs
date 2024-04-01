namespace Core.Models
{
    public class ActiveRoute
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required Cargo Cargo { get; set; }
        
        public required Car Car { get; set; }

        public required Driver Driver { get; set; }

        public required Route Route { get; set; }

        public DateTime DeadLine { get; set; }
    }
}
