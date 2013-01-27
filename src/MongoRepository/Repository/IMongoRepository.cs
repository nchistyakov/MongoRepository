using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository.ObjectModel;

namespace MongoRepository.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(string id);

        TEntity GetSingle(Expression<Func<TEntity, bool>> criteria);
        
        IQueryable<TEntity> GetAll();
        
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria);
        
        TEntity Add(TEntity entity);
        
        void Add(IEnumerable<TEntity> entities);
        
        TEntity Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        void Delete(string id);

        void Delete(TEntity entity);

        void DeleteAll();

        bool Exists(Expression<Func<TEntity, bool>> criteria);

        long Count();
    }
}
