using System;

namespace MongoRepository.NamingStrategies
{
    public interface ICollectionNamingStrategy
    {
        string Apply(string typeName);
    }
}
