namespace DB.Entities;

public class ActiveRouteEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid RouteId { get; set; }

    public Guid DriverId { get; set; }

    public DateTime EndTime { get; set; }

    public Guid CarId { get; set; }

    public Guid CargoId { get; set; }

    public virtual CarEntity? Car { get; set; }

    public virtual CargoEntity? Cargo { get; set; }

    public virtual DriverEntity? Driver { get; set; }

    public virtual RouteEntity? Route { get; set; }
}
