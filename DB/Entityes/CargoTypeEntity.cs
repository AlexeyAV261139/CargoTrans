namespace DB.Entities;

public class CargoTypeEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<CargoEntity> Cargos { get; set; } = [];
}
