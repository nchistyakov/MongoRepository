using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoRepository.ObjectModel
{
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class Entity : IEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
