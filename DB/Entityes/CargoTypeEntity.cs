namespace DB.Entities;

public partial class CargoTypeEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<CargoEntity> Cargos { get; set; } = new List<CargoEntity>();
}
