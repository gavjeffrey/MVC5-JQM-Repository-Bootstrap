using System.Collections.Generic;

namespace MVC5Bootstrap.Infrastructure.Repository
{
    public interface IRepository <TEntity> where TEntity: class
    {
        IList<TEntity> GetAll();
        TEntity GetById(object id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
