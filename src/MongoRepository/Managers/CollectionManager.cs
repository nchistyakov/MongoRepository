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

        public CollectionManager(MongoDatabase mongoDatabase, DefaultCollectionNaming collectionNaming)
        {
            if (mongoDatabase == null)
            {
                throw new ArgumentException("mongoDatabase");
            }

            if (collectionNaming == null)
            {
                throw new ArgumentException("collectionNaming");
            }

            _mongoDatabase = mongoDatabase;
            _namingStrategy = collectionNaming;
        }

        public MongoCollection<TEntity> GetCollection<TEntity>()
        {
            var collectionName = _namingStrategy.Apply(typeof (TEntity).Name);
            return _mongoDatabase.GetCollection<TEntity>(collectionName);
        }
    }
}