using backend.Entities.Interface;

namespace backend.Repositories.Utils;

public abstract class AbstractRepository<T> : IRepository<T> where T : ID
{
    protected List<T> data;
    
    public Task<List<T>> GetAll()
    {
        return Task.FromResult(data);
    }

    public Task<T> Crete(T entity)
    {
        data.Add(entity);
        return Task.FromResult(entity);
    }
}