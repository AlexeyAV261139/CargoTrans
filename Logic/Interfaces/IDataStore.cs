namespace Logic.Interfaces
{
    public interface IDataStore
    {
        Task<IEnumerable<T>> GetByType<T>(T type);

        Task<>
    }
}
