namespace DB.Entities;

public partial class ActiveRouteEntity
{
    public int Id { get; set; }

    public int? RouteId { get; set; }

    public int? DriverId { get; set; }

    public DateTime EndTime { get; set; }

    public int? CarId { get; set; }

    public int? CargoId { get; set; }

    public virtual CarEntity? Car { get; set; }

    public virtual CargoEntity? Cargo { get; set; }

    public virtual DriverEntity? Driver { get; set; }

    public virtual RouteEntity? Route { get; set; }
}
