using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoRepository.ObjectModel
{
    public interface IEntity
    {
        [BsonId]
        string Id { get; set; }
    }
}
