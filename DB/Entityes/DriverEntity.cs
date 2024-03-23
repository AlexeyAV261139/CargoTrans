namespace DB.Entities;

public class DriverEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public  List<ActiveRouteEntity> ActiveRoutes { get; set; } = [];
}
