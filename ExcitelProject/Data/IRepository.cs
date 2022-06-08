namespace ExcitelProject.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> Index();
        Task<T> Details(int id);
        Task<T> Create(T entity);
        Task<T> Edit(T entity);
    }
}
