using Core.Models;

namespace DB.Entities.Extensions;

public static class CargoEntityExtensions
{
    public static Cargo ToCoreModel(this CargoEntity entity)
        => new Cargo
        {
            Id = entity.Id,
            Type = entity.CargoType.ToCoreModel()
        };
}
