namespace DB.Entities;

public partial class ActiveRoute
{
    public int Id { get; set; }

    public int? RouteId { get; set; }

    public int? DriverId { get; set; }

    public DateTime EndTime { get; set; }

    public int? CarId { get; set; }

    public int? CargoId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Cargo? Cargo { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual Route? Route { get; set; }
}
