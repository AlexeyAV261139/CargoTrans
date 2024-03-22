using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Interfaces.Services
{
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task CreateCar(Car car)
        {
            await _carRepository.Create(car);
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.Get();
        }



    }
}
