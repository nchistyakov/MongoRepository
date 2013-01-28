using System;
using NUnit.Framework;

namespace MongoRepository.Tests
{
    public class BaseTestFixture
    {
        [TestFixtureSetUp]
        protected virtual void Setup()
        {
        
        
        }

        [TestFixtureTearDown]
        protected virtual void TearDown()
        {
        }
    }
}
