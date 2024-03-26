using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Interfaces.Services
{
    public class CargoService(ICargosRepository cargosRepository)
    {
        private readonly ICargosRepository _cargosRepository = cargosRepository;

        public async Task CreateCargoAsync(Cargo cargo)
        {
            await _cargosRepository.Create(cargo);
        }

        public async Task<List<Cargo>> GetCargosAsync()
        {
            return await _cargosRepository.Get();
        }
    }
}
