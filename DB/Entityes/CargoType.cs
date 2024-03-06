using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class CargoType
{
    public int Id { get; set; }

    public string? Size { get; set; }

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
}
