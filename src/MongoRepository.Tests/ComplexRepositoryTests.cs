using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoRepository.ObjectModel;
using MongoRepository.Repository;
using NUnit.Framework;

namespace MongoRepository.Tests
{
    [TestFixture]
    public class ComplexRepositoryTests : BaseTestFixture
    {
        private class ClassTest : Entity
        {
            public int IntProperty { get; set; }
            public IList<ChildClassTest> ChildClassTests { get; set; }
        }

        private class ChildClassTest
        {
            public string StringProperty { get; set; }
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

            var classTest = new ClassTest()
                {
                    IntProperty = 10,
                    ChildClassTests = new List<ChildClassTest>()
                        {
                            new ChildClassTest() {StringProperty = "first string"},
                            new ChildClassTest() {StringProperty = "second string"}
                        }
                };

            repository.Add(classTest);

            var count = repository.Count();

            Assert.AreEqual(1, count);
        }
    }
}
