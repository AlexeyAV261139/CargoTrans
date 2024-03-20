namespace DB
{
    public class Repository
    {
        private readonly CargosDbContext _dbContext;

        public Repository(CargosDbContext cargosDbContext)
        {
            _dbContext = cargosDbContext;
        }

        public IQueryable<> GetCargos()
        {
            var cargos = _dbContext.Cargos.Join(_dbContext.CargoTypes,
                c => c.CargoTypeId,
                ct => ct.Id,
                (c, ct) => new
                {
                    Type = ct.Name,
                    c.Requirements
                });
            return cargos;

        }
    }
}
