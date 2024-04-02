using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class RouteRepository(CargosDbContext context) : IRouteRepository
    {
        private readonly CargosDbContext _context = context;

        public async Task Create(Route route)
        {
            var routeEntity = new RouteEntity
            {
                Id = route.Id,
                Destination = route.Destination,
                DistancePerKm = route.Distance,
                Price = route.Price
            };
            await _context.Routes.AddAsync(routeEntity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Route>> Get()
        {
            return _context.Routes
                .Select(r => new Route
                {
                    Id = r.Id,
                    Destination = r.Destination,
                    Distance = r.DistancePerKm,
                    Price = r.Price
                })
                .ToListAsync();
        }

        public Task<Route> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Route route)
        {
            throw new NotImplementedException();
        }
    }
}
