namespace Application.Interfaces.Repositories
{
    public interface IRouteRepository
    {
        Task Create(Route cargo);
        Task Delete(Guid id);
        Task<List<Route>> Get();
        Task<Route> GetById(Guid id);
        Task Update(Route cargo);
    }
}
