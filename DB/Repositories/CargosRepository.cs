using Application.Interfaces.Repositories;
using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargosRepository : ICargosRepository
    {
        private readonly CargosDbContext _dbContext;
        private readonly DbSet<CargoEntity> _cargos;

        public CargosRepository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
            _cargos = _dbContext.Cargos;
        }

        public Task Create(Cargo cargo)
        {
            await _cargos.AddAsync(cargo);
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CargoEntity>> Get()
        {
            return await _cargos
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Cargo> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CargoEntity>> GetWithType()
        {
            return await _cargos
                .Include(c => c.CargoType)
                .ToListAsync();
        }

        public Task Update(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        Task<List<Cargo>> ICargosRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
