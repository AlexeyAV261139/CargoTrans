using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class CarEntity
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int LoadCapacityPerKg { get; set; }

    public virtual ICollection<ActiveRouteEntity> ActiveRoutes { get; set; } = new List<ActiveRouteEntity>();
}
