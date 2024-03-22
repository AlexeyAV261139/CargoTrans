using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CarRepository
    {
        private readonly CargosDbContext _dbContext;
        private readonly DbSet<CarEntity> _cargos;

        public Task Add(CargoEntity cargo)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CargoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CarEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CargoEntity>> GetWithInclude()
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }
    }
}
