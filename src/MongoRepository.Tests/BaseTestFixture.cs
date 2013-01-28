using System;
using MongoDB.Driver;
using NUnit.Framework;

namespace MongoRepository.Tests
{
    [TestFixture]
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
