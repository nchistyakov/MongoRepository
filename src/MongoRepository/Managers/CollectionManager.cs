using System;
using MongoDB.Driver;
using MongoRepository.Conventions;

namespace MongoRepository.Managers
{
    public class CollectionManager : ICollectionManager
    {
        private MongoDatabase _mongoDatabase;
        private ICollectionNamingStrategy _namingStrategy;

        public CollectionManager(MongoDatabase mongoDatabase)
            : this(mongoDatabase, new DefaultCollectionNaming()) { }

        public CollectionManager(MongoDatabase mongoDatabase, ICollectionNamingStrategy collectionNamingStrategy)
        {
            if (mongoDatabase == null)
            {
                throw new ArgumentException("mongoDatabase");
            }

            if (collectionNamingStrategy == null)
            {
                throw new ArgumentException("collectionNamingStrategy");
            }

            _mongoDatabase = mongoDatabase;
            _namingStrategy = collectionNamingStrategy;
        }

        public MongoCollection<TEntity> GetCollection<TEntity>()
        {
            var collectionName = _namingStrategy.Apply(typeof(TEntity).Name);
            return _mongoDatabase.GetCollection<TEntity>(collectionName);
        }
    }
}