using System;
using System.Collections.Generic;

namespace DB.Entities;

public partial class CargoTypeEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CargoEntity> Cargos { get; set; } = new List<CargoEntity>();
}
