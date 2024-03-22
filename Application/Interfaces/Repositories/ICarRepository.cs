using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface ICarRepository
    {
        Task Create(Car cargo);
        Task Delete(Guid id);
        Task<List<Car>> Get();
        Task<Car> GetById(Guid id);
        Task Update(Car cargo);
    }
}
