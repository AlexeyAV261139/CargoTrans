using Core.Models;
using DB.Entities;

namespace DB.Repositories
{
    public interface IRepository
    {
        Task Add(CargoEntity cargo);

        Task<List<CargoEntity>> Get();

        Task<CarEntity> GetById(Guid id);

        Task<List<CargoEntity>> GetWithInclude();

        Task Delete(Guid id);

        Task Update();
    }
}