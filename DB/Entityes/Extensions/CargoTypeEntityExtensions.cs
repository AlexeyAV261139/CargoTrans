using Core.Models;

namespace DB.Entities.Extensions;

public static class CargoTypeEntityExtensions
{
    public static CargoType ToCoreModel(this CargoTypeEntity entity)
        => new CargoType { Id = entity.Id, Name = entity.Name };
}
