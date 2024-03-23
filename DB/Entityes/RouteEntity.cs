namespace DB.Entities;

public class RouteEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Destination { get; set; } = string.Empty;

    public int DistancePerKm { get; set; }

    public decimal Price{ get; set; }

    public List<ActiveRouteEntity> ActiveRoutes { get; set; } = [];
}
