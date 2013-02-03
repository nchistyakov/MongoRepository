using System;
using MongoDB.Driver;
using MongoRepository.Configurations;

namespace MongoRepository.Managers
{
    public class CollectionManager : ICollectionManager
    {
        private MongoDatabase _mongoDatabase;
        private FluentConfiguration _fluentConfiguration;

        public CollectionManager(MongoDatabase mongoDatabase)
            : this(mongoDatabase, new FluentConfiguration()) { }

        public CollectionManager(MongoDatabase mongoDatabase, FluentConfiguration fluentConfiguration)
        {
            if (mongoDatabase == null)
            {
                throw new ArgumentException("mongoDatabase");
            }

            if (fluentConfiguration == null)
            {
                throw new ArgumentException("fluentConfiguration");
            }

            _mongoDatabase = mongoDatabase;
            _fluentConfiguration = fluentConfiguration;
        }

        public MongoCollection<TEntity> GetCollection<TEntity>()
        {
            var collectionName = this.GetCollectionName<TEntity>();
            return _mongoDatabase.GetCollection<TEntity>(collectionName);
        }

        #region Private methods

        private string GetCollectionName<TEntity>()
        {
            var namingStrategy = _fluentConfiguration.GetCollectionNamingStrategy();
            var collectionName = namingStrategy.Apply(typeof(TEntity).Name);

            return collectionName;
        }

        #endregion
    }
}