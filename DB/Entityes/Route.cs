using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class Route
{
    public int Id { get; set; }

    public string Destination { get; set; } = null!;

    public int? DistancvePerKm { get; set; }

    public int? PricePerPenny { get; set; }

    public virtual ICollection<ActiveRoute> ActiveRoutes { get; set; } = new List<ActiveRoute>();
}
