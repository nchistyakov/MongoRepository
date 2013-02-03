using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository.ObjectModel;

namespace MongoRepository.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(string id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        TEntity GetSingle(Expression<Func<TEntity, bool>> criteria);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> criteria);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Add(TEntity entity);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Add(IEnumerable<TEntity> entities);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<TEntity> entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        bool Exists(Expression<Func<TEntity, bool>> criteria);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        long Count();
    }
}
