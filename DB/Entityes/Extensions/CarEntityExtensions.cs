using Core.Models;

namespace DB.Entities.Extensions;

public static class CarEntityExtensions
{
    public static Car ToCoreModel(this CarEntity entity)
        => new()
        {
            Id = entity.Id,
            Brand = entity.Brand,
            Number = entity.Number,
            LoadCapacityPerKg = entity.LoadCapacityPerKg
        };
}
