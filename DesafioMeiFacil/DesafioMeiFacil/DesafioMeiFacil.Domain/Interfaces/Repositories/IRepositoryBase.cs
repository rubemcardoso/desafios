using System.Collections.Generic;

namespace DesafioMeiFacil.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        
        void AddRange(IEnumerable<TEntity> obj);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllAsNoTracking();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
