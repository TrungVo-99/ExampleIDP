using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExampleIDP.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        int Count();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> include);
        TEntity GetSingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();


        void DetachLocal<T>(T t, int entityId) where T : class;
    }
}
