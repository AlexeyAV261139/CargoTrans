namespace DB.Entities;

public partial class CargoType
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();
}
