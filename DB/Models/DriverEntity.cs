using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class DriverEntity
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<ActiveRouteEntity> ActiveRoutes { get; set; } = new List<ActiveRouteEntity>();
}
