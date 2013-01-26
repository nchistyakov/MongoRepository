using MongoDB.Bson.Serialization.Attributes;

namespace MongoRepository.Data
{
    public interface IEntity
    {
        [BsonId]
        string Id { get; set; }
    }
}
