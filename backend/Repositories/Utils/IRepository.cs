namespace backend.Repositories.Utils;

public interface IRepository<T>
{
        public Task<List<T>> GetAll();
        public Task<T> Crete(T entity);
}