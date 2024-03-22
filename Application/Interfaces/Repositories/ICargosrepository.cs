using Core.Models;

namespace Application.Interfaces.Repositories
{
    public interface ICargosRepository
    {
        Task Create(Cargo cargo);
        Task Delete(Guid id);
        Task <List<Cargo>> Get();
        Task <Cargo> GetById(Guid id);
        Task <Cargo> Update(Guid id, )
    }
}
