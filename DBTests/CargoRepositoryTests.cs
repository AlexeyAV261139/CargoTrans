using Core.Models;
using DB;
using DB.Repositories;

namespace DBTests
{
    public class CargoRepositoryTests
    {
        private readonly CargoRepository _repository = new CargoRepository(new CargosDbContext());
       

        [Fact]
        public async void Create()
        {
            var cargo = new Cargo { Requirements = "Îñòîðîæíî", Type = "gfdsfhà" };

            await _repository.Create(cargo);

            
        }
    }
}