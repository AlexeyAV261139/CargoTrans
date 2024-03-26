using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Interfaces.Services
{
    public class RouteService(IRouteRepository repository)
    {
        private readonly IRouteRepository _repository = repository;

        public async Task CreateCargoAsync(Route route)
        {
            await _repository.Create(route);
        }

        public async Task<List<Route>> GetCargosAsync()
        {
            return await _repository.Get();
        }
    }
}
