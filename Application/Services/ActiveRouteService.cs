using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Services
{
    public class ActiveRouteService(IActiveRouteRepository repository)
    {
        private readonly IActiveRouteRepository _repository = repository;

        public async Task CreateActiveRoute(ActiveRoute activeRoute)
        {
            await _repository.Create(activeRoute);
        }

        public async Task<List<ActiveRoute>> GetActiveRoutesAsync()
        {
            return await _repository.Get();
        }
    }
}
