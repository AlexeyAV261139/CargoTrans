using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface IActiveRouteRepository
    {
        Task Create(ActiveRoute activeRoute);
        Task Delete(Guid id);
        Task<List<ActiveRoute>> Get();
        Task<ActiveRoute> GetById(Guid id);
        Task Update(ActiveRoute activeRoute);
    }
}
