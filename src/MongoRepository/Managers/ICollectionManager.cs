using MongoDB.Driver;
using MongoRepository.Conventions;

namespace MongoRepository.Managers
{
    public interface ICollectionManager
    {
        ICollectionNamingStrategy NamingStrategy { get; set; }
        MongoCollection<TEntity> GetCollection<TEntity>();
    }
}
