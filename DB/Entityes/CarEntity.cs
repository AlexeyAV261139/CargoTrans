namespace DB.Entities;

public class CarEntity
{
    public Guid Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int LoadCapacityPerKg { get; set; }

    public List<ActiveRouteEntity> ActiveRoutes { get; set; } = [];
}
