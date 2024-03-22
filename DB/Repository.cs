using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class Repository
    {
        private readonly CargosDbContext _dbContext;

        public Repository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
        }

        public IQueryable<Cargo> GetCargos()
        {
            var cargos = _dbContext.Cargos.Join(_dbContext.CargoTypes,
                c => c.CargoTypeId,
                ct => ct.Id,
                (c, ct) => new Cargo
                {
                    Type = ct.Name,
                    Requirements = c.Requirements
                });
            return cargos;

        }
    }
}
