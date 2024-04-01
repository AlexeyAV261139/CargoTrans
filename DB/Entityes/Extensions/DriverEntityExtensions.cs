using Core.Models;

namespace DB.Entities.Extensions;

public static class DriverEntityExtensions
{
    public static Driver ToCoreModel(this DriverEntity entity)
        => new()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Phone = entity.Phone,
        };
}
