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


        public async Task Create(ActiveRoute activeRoute)
        {
            await CheckExistEntitiesAndCreateIfNull(activeRoute);

            var activeRouteEntity = new ActiveRouteEntity
            {
                Id = activeRoute.Id,
                CargoId = activeRoute.Cargo.Id,
                CarId = activeRoute.Car.Id,
                DriverId = activeRoute.Driver.Id,
                RouteId = activeRoute.Route.Id,
            };
            await _context.ActiveRoutes.AddAsync(activeRouteEntity);
            await _context.SaveChangesAsync();

        }

        private async Task CheckExistEntitiesAndCreateIfNull(ActiveRoute activeRoute)
        {
            var cargo = await _cargosRepository.GetById(activeRoute.Cargo.Id);
            if (cargo is null) await _cargosRepository.Create(activeRoute.Cargo);

            var car = await _carRepository.GetById(activeRoute.Car.Id);
            if (car is null) await _carRepository.Create(activeRoute.Car);

            var driver = await _driverRepository.GetById(activeRoute.Driver.Id);
            if (driver is null) await _driverRepository.Create(activeRoute.Driver);

            var route = await _routeRepository.GetById(activeRoute.Route.Id);
            if (driver is null) await _routeRepository.Create(activeRoute.Route);
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
                    Cargo = new Cargo
                    {
                        Id = r.Cargo
                    }
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
