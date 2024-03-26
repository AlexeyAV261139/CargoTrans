using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoTypesRepository(CargosDbContext context) : ICargoTypesRepository
    {
        private readonly CargosDbContext _context = context;

        public async Task Create(CargoType cargoType)
        {
            var typeEntity = new CargoTypeEntity()
            {
                Id = cargoType.Id,
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

        public async Task<CargoType?> GetByName(string name)
        {
            var typeEntity = await _context.CargoTypes.FirstOrDefaultAsync(t => t.Name == name);
            if (typeEntity == null)
                return null;
            var type = new CargoType
            {
                Id = typeEntity.Id,
                Name = typeEntity.Name
            };
            return type;
        }

        public async Task<CargoType> GetOrCreateByName(string name)
        {
            var type = await GetByName(name);

            if (type == null)
            {
                type = new CargoType
                {
                    Name = name
                };
                await Create(type);                
            }
            return type;
            
        }

        public Task Update(CargoType cargo)
        {
            throw new NotImplementedException();
        }
    }
}
