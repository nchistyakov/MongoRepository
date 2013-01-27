using System;
using MongoDB.Driver;

namespace MongoRepository.Managers
{
    public interface ICollectionManager
    {
        MongoCollection<TEntity> GetCollection<TEntity>();
    }
}
