using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class ActiveRouteRepository(CargosDbContext context) : IActiveRouteRepository
    {
        private readonly CargosDbContext _context = context;

        private readonly ICargosRepository _cargosRepository = new CargoRepository(context);
        private readonly ICarRepository _carRepository = new CarRepository(context);
        private readonly IDriverRepository _driverRepository = new DriverRepository(context);
        private readonly IRouteRepository _routeRepository = new RouteRepository(context);

        public Task Create(ActiveRoute activeRoute)
        {
            throw new Exception();
            //var activeRouteEntity = new ActiveRouteEntity
            //{
            //    Id = activeRoute.Id,
            //    CargoId = activeRoute.Cargo.Id,
            //    CarId = activeRoute.Car.Id,
            //    DriverId = activeRoute.Driver.Id,
            //    EndTime = activeRoute.DeadLine,
            //    RouteId = activeRoute.Route.Id
            //};
            //_context.ActiveRoutes.AddAsync(activeRouteEntity);
            //_context.SaveChanges();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ActiveRoute>> Get()
        {
            return await _context.ActiveRoutes
                .Select(r => new ActiveRoute
                {
                    Id = r.Id,
                    CarBrand = r.Car.Brand,
                    DriverName = r.Driver.FirstName,
                    Destination = r.Route.Destination,
                    DeadLine = r.EndTime
                })
                .ToListAsync();                
        }

        public Task<ActiveRoute> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ActiveRoute cargo)
        {
            throw new NotImplementedException();
        }
    }
}
