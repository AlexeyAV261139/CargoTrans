namespace DB.Entities;

public partial class CargoEntity
{
    public int Id { get; set; }

    public int? CargoTypeId { get; set; }

    public string? Requirements { get; set; }

    public virtual ICollection<ActiveRouteEntity> ActiveRoutes { get; set; } = new List<ActiveRouteEntity>();

    public virtual CargoTypeEntity? CargoType { get; set; }
}
