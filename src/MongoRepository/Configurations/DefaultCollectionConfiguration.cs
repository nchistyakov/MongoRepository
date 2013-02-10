using System;
using MongoRepository.Conventions;

namespace MongoRepository.Configurations
{
    public class DefaultCollectionConfiguration : ICollectionConfiguration
    {
        public ICollectionNamingStrategy CollectionNamingStrategy { get; set; }

        public DefaultCollectionConfiguration()
        {
            this.CollectionNamingStrategy = new DefaultCollectionNaming();
        }
    }
}
