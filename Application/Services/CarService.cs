using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Services
{
    public class CarService(ICarRepository carRepository)
    {
        private readonly ICarRepository _carRepository = carRepository;

        public async Task CreateCar(Car car)
        {
            await _carRepository.Create(car);
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await _carRepository.Get();
        }
    }
}
