using Core.Models;
using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargosRepository
    {
        private readonly CargosDbContext _dbContext;
        private readonly DbSet<CargoEntity> _cargos;

        public CargosRepository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
            _cargos = _dbContext.Cargos;
        }

        public async Task<List<CargoEntity>> Get()
        {
            return await _cargos
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<CargoEntity>> GetWithInclude()
        {
            return await _cargos
                .Include(c => c.CargoType)
                .ToListAsync();
        }

        public async Task<CarEntity> GetById(Guid id)
        {
            throw new Exception();
        }

        public async Task Add(CargoEntity cargo)
        {
            throw new Exception();

        }

        public async Task Update()
        {
            throw new Exception();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
