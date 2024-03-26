using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CargosDbContext _dbContext;

        public CarRepository(CargosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Car car)
        {
            var carEntity = new CarEntity
            {
                Id = car.Id,
                Brand = car.Brand,
                Number = car.Number,
                LoadCapacityPerKg = car.LoadCapacityPerKg
            };
            await _dbContext.Cars.AddAsync(carEntity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Car>> Get()
        {
            return await _dbContext.Cars
                .Select(c => new Car
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    LoadCapacityPerKg = c.LoadCapacityPerKg,
                    Number = c.Number
                })
                .ToListAsync();
        }

        public Task<Car> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
