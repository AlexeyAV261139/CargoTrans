namespace DB.Entities;

public class CargoEntity
{
    public Guid Id { get; set; }

    public Guid CargoTypeId { get; set; }

    public string Requirements { get; set; } = string.Empty;

    public List<ActiveRouteEntity> ActiveRoutes { get; set; } = [];

    public CargoTypeEntity? CargoType { get; set; }
}
