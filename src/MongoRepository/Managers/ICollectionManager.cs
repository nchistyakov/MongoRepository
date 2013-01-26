using MongoDB.Driver;
using MongoRepository.NamingStrategies;

namespace MongoRepository.Managers
{
    public interface ICollectionManager
    {
        ICollectionNamingStrategy NamingStrategy { get; set; }
        MongoCollection<TEntity> GetCollection<TEntity>();
    }
}
