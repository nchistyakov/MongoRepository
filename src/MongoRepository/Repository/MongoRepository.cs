using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoRepository.Data;
using MongoRepository.Managers;

namespace MongoRepository.Repository
{
    public class MongoRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly MongoCollection<TEntity> _collection;

        public MongoRepository(ICollectionManager collectionManager)
        {
            this._collection = collectionManager.GetCollection<TEntity>();
        }

        public TEntity GetById(string id)
        {
            return this._collection.FindOneByIdAs<TEntity>(id);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> All(Expression<Func<TEntity, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<TEntity, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }
    }
}
