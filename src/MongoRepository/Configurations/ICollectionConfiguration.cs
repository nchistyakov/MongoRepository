using System;
using MongoRepository.Conventions;

namespace MongoRepository.Configurations
{
    public interface ICollectionConfiguration
    {
        ICollectionNamingStrategy CollectionNamingStrategy { get; set; }
    }
}
