using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
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

        public ICollectionNamingStrategy GetCollectionNamingStrategy()
        {
            return this.CollectionConfiguration.CollectionNamingStrategy;

        }
    }
}
