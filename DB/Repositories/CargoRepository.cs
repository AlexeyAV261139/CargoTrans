using Application.Interfaces.Repositories;
using AutoMapper;
using Core.Models;
using DB.Entities;

namespace DB.Repositories
{
    public class CargoRepository : ICargosRepository
    {
        private readonly CargosDbContext _dbContext;
        private readonly IMapper _mapper;

        public CargoRepository(CargosDbContext cargosDbContext, IMapper mapper)
        {
            _dbContext = cargosDbContext;
            _mapper = mapper;
        }

        public Task Create(Cargo cargo)
        {
            var cargoEntity = new CargoEntity()
            {
                Id = cargo.Id,
                
            };
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
            throw  new NotSupportedException();
        }
    }
}
