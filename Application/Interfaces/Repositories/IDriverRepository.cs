namespace Application.Interfaces.Repositories
{
    public interface IDriverRepository
    {
        Task Create(Driver cargo);
        Task Delete(Guid id);
        Task<List<Driver>> Get();
        Task<Driver> GetById(Guid id);
        Task Update(Driver cargo);
    }
}
