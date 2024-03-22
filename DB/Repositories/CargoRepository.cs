using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class CargoRepository
    {
        private readonly CargosDbContext _dbContext;

        public CargoRepository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
        }

        public List<Cargo> Get()
        {
            return _dbContext.Cargos
                .AsNoTracking()
                .Include(c => c.CargoType)               
                .ToList();
        }
    }
}
