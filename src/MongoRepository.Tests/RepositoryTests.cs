using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MongoRepository.Tests
{
    [TestFixture]
    public class RepositoryTests : BaseTestFixture
    {
        private class TestClass
        {
            public string Id { get; set; }
            public int IntProperty { get; set; }
        }

        [Test]
        public void FirstTest()
        {
            
        }
    }
}
