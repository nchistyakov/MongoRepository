﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoRepository.Managers;
using MongoRepository.ObjectModel;
using NUnit.Framework;
using MongoRepository.Repository;

namespace MongoRepository.Tests
{
    [TestFixture]
    public class RepositoryTests : BaseTestFixture
    {
        private class ClassTest : Entity
        {
            public int IntProperty { get; set; }
        }

        [SetUp]
        public void SetUp()
        {
            var collection = Configuration.TestCollection.GetCollection<ClassTest>();
            collection.RemoveAll();
        }

        [Test]
        public void FirstTest()
        {
            var repository = new MongoRepository<ClassTest>(Configuration.TestCollection);

            var count = repository.Count();

            Assert.AreEqual(0, count);
        }

        [Test]
        public void TestCountOne()
        {
            var repository = new MongoRepository<ClassTest>(Configuration.TestCollection);
            repository.Add(new ClassTest());

            var count = repository.Count();

            Assert.AreEqual(1, count);
        }
    }
}
