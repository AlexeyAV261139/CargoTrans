using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Interfaces.Services
{
    public class CargoTypeService(ICargoTypesRepository typesRepository)
    {
        private readonly ICargoTypesRepository _typesRepository = typesRepository;

        public async Task CreateType(CargoType type)
        {
            await _typesRepository.Create(type);
        }

        public async Task<List<CargoType>> GetCargoTypesAsync()
        {
            return await _typesRepository.Get();
        }
    }
}
