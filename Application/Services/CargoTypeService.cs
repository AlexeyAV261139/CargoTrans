using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Services
{
    public class CargoTypeService(ICargoTypesRepository typesRepository)
    {
        private readonly ICargoTypesRepository _typesRepository = typesRepository;

        public async Task CreateTypeAsync(CargoType type)
        {
            await _typesRepository.Create(type);
        }

        public async Task<CargoType?> GetByName(string name)
        {
            return await _typesRepository.GetByName(name);
        }

        public async Task<List<CargoType>> GetCargoTypesAsync()
        {
            return await _typesRepository.Get();
        }
    }
}
