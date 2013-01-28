using System;
using System.Configuration;
using MongoDB.Driver;
using MongoRepository.Managers;

namespace MongoRepository.Tests
{
    public static class Configuration
    {
        // private static fields
        private static MongoClient __testClient;
        private static MongoServer __testServer;
        private static MongoDatabase __testDatabase;
        private static ICollectionManager __testCollection;

        // static constructor
        //static Configuration()
        //{
        //    var connectionString = //ConfigurationManager.ConnectionStrings["MongoRepositoryTestsConnectionString"].ConnectionString ?? 
        //        "mongodb://localhost/?w=1";

        //    var mongoUrl = new MongoUrl(connectionString);
        //    var clientSettings = MongoClientSettings.FromUrl(mongoUrl);
        //    if (!clientSettings.WriteConcern.Enabled)
        //    {
        //        clientSettings.WriteConcern.W = 1; // ensure WriteConcern is enabled regardless of what the URL says
        //    }

        //    __testClient = new MongoClient(clientSettings);
        //    __testServer = __testClient.GetServer();
        //    __testDatabase = __testServer.GetDatabase("csharpdriverunittests");
        //    __testCollection = new CollectionManager(__testDatabase);
        //}

        static Configuration()
        {
            var connectionString =
                ConfigurationManager.ConnectionStrings["MongoRepositoryTestsConnectionString"].ConnectionString;
                

            var mongoUrl = new MongoUrl(connectionString);
            var clientSettings = MongoClientSettings.FromUrl(mongoUrl);
            if (!clientSettings.WriteConcern.Enabled)
            {
                clientSettings.WriteConcern.W = 1; // ensure WriteConcern is enabled regardless of what the URL says
            }

            __testClient = new MongoClient(clientSettings);
            __testServer = __testClient.GetServer();
            __testDatabase = __testServer.GetDatabase("MongoRepositoryTests");
            __testCollection = new CollectionManager(__testDatabase);
        }
        
        // public static properties
        /// <summary>
        /// Gets the test client.
        /// </summary>
        public static MongoClient TestClient
        {
            get { return __testClient; }
        }

        /// <summary>
        /// Gets the test collection.
        /// </summary>
        public static ICollectionManager TestCollection
        {
            get { return __testCollection; }
        }

        /// <summary>
        /// Gets the test database.
        /// </summary>
        public static MongoDatabase TestDatabase
        {
            get { return __testDatabase; }
        }

        /// <summary>
        /// Gets the test server.
        /// </summary>
        public static MongoServer TestServer
        {
            get { return __testServer; }
        }
    }
}
