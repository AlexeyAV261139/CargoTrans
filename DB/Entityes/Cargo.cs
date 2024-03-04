namespace DB.Entities;

public partial class Cargo
{
    public int Id { get; set; }

    public int? CargoTypeId { get; set; }

    public string? Requirements { get; set; }

    public virtual ICollection<ActiveRoute> ActiveRoutes { get; set; } = new List<ActiveRoute>();

    public virtual CargoType? CargoType { get; set; }
}
