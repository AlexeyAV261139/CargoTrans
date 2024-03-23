using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface ICargoTypesRepository
    {
        Task Create(CargoType cargo);
        Task Delete(Guid id);
        Task<List<CargoType>> Get();
        Task<CargoType> GetById(Guid id);
        Task<CargoType> GetOrCreateByName(string name);

        Task Update(CargoType cargo);
    }
}
