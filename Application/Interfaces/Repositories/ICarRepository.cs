using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface ICarRepository
    {
        Task Create(Car car);
        Task Delete(Guid id);
        Task<List<Car>> Get();
        Task<Car> GetById(Guid id);
        Task Update(Car car);
    }
}
