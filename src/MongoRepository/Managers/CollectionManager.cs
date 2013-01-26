using System;
using MongoDB.Driver;
using MongoRepository.NamingStrategies;

namespace MongoRepository.Managers
{
    public class CollectionManager : ICollectionManager
    {
        private readonly MongoDatabase _mongoDatabase;

        public ICollectionNamingStrategy NamingStrategy { get; set; }

        public CollectionManager(MongoDatabase mongoDatabase)
        {
            _mongoDatabase = mongoDatabase;
            this.NamingStrategy = new DefaultCollectionNaming();
        }

        public MongoCollection<TEntity> GetCollection<TEntity>()
        {
            var collectionName = this.NamingStrategy.Apply(typeof (TEntity).Name);
            return _mongoDatabase.GetCollection<TEntity>(collectionName);
        }
    }
}