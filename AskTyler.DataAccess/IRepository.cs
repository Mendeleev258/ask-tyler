using AskTyler.DataAccess.Entities;

namespace AskTyler.DataAccess;

public interface IRepository<T> where T : IBaseEntity
{
    IEnumerable<T> GetAll();
    
    T? GetById(int id);
    
    T? GetById(Guid id);
    
    T Save(T entity);
    
    void Delete(T entity);
}