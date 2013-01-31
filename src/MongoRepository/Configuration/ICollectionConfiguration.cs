using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoRepository.Conventions;

namespace MongoRepository.Configuration
{
    interface ICollectionConfiguration
    {
        ICollectionNamingStrategy CollectionNamingStrategy { get; set; }
    }
}
