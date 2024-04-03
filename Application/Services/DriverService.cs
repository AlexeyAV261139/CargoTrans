using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Services
{
    public class DriverService(IDriverRepository repository)
    {
        private readonly IDriverRepository _repository = repository;

        public async Task CreateDriverAsync(Driver driver)
        {
            await _repository.Create(driver);
        }

        public async Task<List<Driver>> GetDriversAsync()
        {
            return await _repository.Get();
        }
    }
}
