using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface IRouteRepository
    {
        Task Create(Route route);
        Task Delete(Guid id);
        Task<List<Route>> Get();
        Task<Route> GetById(Guid id);
        Task Update(Route route);
    }
}
