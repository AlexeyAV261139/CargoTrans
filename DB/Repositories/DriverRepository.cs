using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class DriverRepository(CargosDbContext context) : IDriverRepository
    {
        private readonly CargosDbContext _context = context;        

        public async Task Create(Driver driver)
        {
            var driverEntity = new DriverEntity
            {
                Id = driver.Id,
                FirstName = driver.FirstName,
                LastName = driver.LastName,
                Phone = driver.Phone
            };
            await _context.Drivers.AddAsync(driverEntity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Driver>> Get()
        {
            return await _context.Drivers
                .Select(d => new Driver
                {
                    Id = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Phone = d.Phone                    
                })
                .ToListAsync();
        }

        public Task<Driver> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Driver cargo)
        {
            throw new NotImplementedException();
        }
    }
}
