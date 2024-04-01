using Core.Models;

namespace DB.Entities.Extensions;

public static class RouteEntityExtensions
{
    public static Route ToCoreModel(this RouteEntity entity)
        => new Route
        {
            Id = entity.Id,
            Destination = entity.Destination,
            Distance = entity.DistancePerKm,
            Price = entity.Price,
        };
}