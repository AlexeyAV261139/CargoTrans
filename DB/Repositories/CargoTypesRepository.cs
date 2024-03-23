using Application.Interfaces.Repositories;
using AutoMapper;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoTypesRepository : ICargoTypesRepository
    {
        private readonly CargosDbContext _context;

        public CargoTypesRepository(CargosDbContext context)
        {
            _context = context;
        }

        public async Task Create(CargoType cargoType)
        {
            var typeEntity = new CargoTypeEntity()
            {
                Name = cargoType.Name,
            };
            await _context.CargoTypes.AddAsync(typeEntity);
            _context.SaveChanges();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CargoType>> Get()
        {
            return await _context.CargoTypes.
                Select(t => new CargoType 
                { 
                    Id = t.Id, 
                    Name = t.Name
                })
                .ToListAsync();             
        }

        public Task<CargoType> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoType> GetOrCreateByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(CargoType cargo)
        {
            throw new NotImplementedException();
        }
    }
}
