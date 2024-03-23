using Application.Interfaces.Repositories;
using AutoMapper;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoRepository : ICargosRepository
    {
        private readonly CargosDbContext _dbContext;
        private readonly ICargoTypesRepository _typesRepository;

        public CargoRepository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
            _typesRepository = new CargoTypesRepository(cargosDbContext);
        }

        public async Task Create(Cargo cargo)
        {
            var type = await _typesRepository.GetOrCreateByName(cargo.Type);
            var cargoEntity = new CargoEntity()
            {
                Id = cargo.Id,
                CargoTypeId = type.Id,
                Requirements = cargo.Requirements
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
                Type = c.CargoType.Name,
                Requirements = c.Requirements
            }).ToList();                         

            return cargos;
        }
    }
}
