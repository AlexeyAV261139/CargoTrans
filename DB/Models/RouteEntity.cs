using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class RouteEntity
{
    public int Id { get; set; }

    public string Destination { get; set; } = null!;

    public int? DistancvePerKm { get; set; }

    public int? PricePerPenny { get; set; }

    public virtual ICollection<ActiveRouteEntity> ActiveRoutes { get; set; } = new List<ActiveRouteEntity>();
}
