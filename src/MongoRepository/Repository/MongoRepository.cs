﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoRepository.Managers;
using MongoRepository.ObjectModel;

namespace MongoRepository.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class MongoRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly MongoCollection<TEntity> _collection;

        public MongoRepository(ICollectionManager collectionManager)
        {
            if (collectionManager == null)
            {
                throw new ArgumentException("collectionManager");
            }

            _collection = collectionManager.GetCollection<TEntity>();
        }

        public TEntity GetById(string id)
        {
            return _collection.FindOneByIdAs<TEntity>(id);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> criteria)
        {
            return _collection.AsQueryable().Where(criteria).FirstOrDefault();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _collection.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria)
        {
            return _collection.AsQueryable().Where(criteria);
        }

        public TEntity Add(TEntity entity)
        {
            _collection.Insert(entity);
            return entity;
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            _collection.InsertBatch(entities);
        }

        public TEntity Update(TEntity entity)
        {
            _collection.Save(entity);
            return entity;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _collection.Save(entity);
            }
        }

        public void Delete(string id)
        {
            _collection.Remove(Query.EQ("_id", id));
        }

        public void Delete(TEntity entity)
        {
            this.Delete(entity.Id);
        }

        public void DeleteAll()
        {
            _collection.RemoveAll();
        }

        public bool Exists(Expression<Func<TEntity, bool>> criteria)
        {
            return _collection.AsQueryable().Any(criteria);
        }

        public long Count()
        {
            return _collection.Count();
        }
    }
}
