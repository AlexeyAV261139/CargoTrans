using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoRepository(CargosDbContext cargosDbContext) : ICargosRepository
    {
        private readonly CargosDbContext _dbContext = cargosDbContext;
        private readonly CargoTypesRepository _typesRepository = new(cargosDbContext);

        public async Task Create(Cargo cargo)
        {
            var type = await _typesRepository.GetByName(cargo.Type.Name);
            if (type == null)
            {                
                type = cargo.Type;
                await _typesRepository.Create(type);
            }
            var cargoEntity = new CargoEntity()
            {
                Id = cargo.Id,
                CargoTypeId = type.Id
            };
            await _dbContext.Cargos.AddAsync(cargoEntity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Cargo> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cargo>> Get()
        {
            var cargosEntity = await _dbContext.Cargos.Include(c => c.CargoType).ToListAsync();
            var cargos = cargosEntity.Select(c => new Cargo
            {
                Id = c.Id,
                Type = new CargoType
                {
                    Id = c.CargoType.Id,
                    Name = c.CargoType.Name,
                }
            }).ToList();                         

            return cargos;
        }
    }
}
