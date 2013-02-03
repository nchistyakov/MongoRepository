using System;
using System.Runtime.Serialization;
using MongoRepository.Conventions;

namespace MongoRepository.Configurations
{
    [Serializable]
    public class FluentConfiguration : ISerializable
    {
        protected ICollectionConfiguration CollectionConfiguration;
        protected IDatabaseConfiguration DatabaseConfiguration;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public virtual ICollectionNamingStrategy GetCollectionNamingStrategy()
        {
            return this.CollectionConfiguration.CollectionNamingStrategy;
        }
    }
}
