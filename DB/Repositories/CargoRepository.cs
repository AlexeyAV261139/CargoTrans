using Application.Interfaces.Repositories;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoRepository : ICargosRepository
    {
        private readonly CargosDbContext _dbContext;

        public CargoRepository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
        }

        public Task Create(Cargo cargo)
        {
            throw new NotImplementedException();
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
            return await _dbContext.Cargos
                           .AsNoTracking()
                           .Include(c => c.CargoType)
                           .ToListAync();
        }
    }
}
