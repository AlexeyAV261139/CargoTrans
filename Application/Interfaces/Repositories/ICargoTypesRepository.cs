using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface ICargoTypesRepository
    {
        Task Create(CargoType cargo);
        Task<List<CargoType>> Get();
        Task<CargoType?> GetById(Guid id);
        Task<CargoType?> GetByName(string name);
    }
}
