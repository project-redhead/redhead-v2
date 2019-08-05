using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace ProjectRedhead.Core.Infrastructure
{
    public class DatabaseProvider
    {
        public string ConnectionString { get; }
        public string DatabaseName { get; }

        public DatabaseProvider(string connectionString, string databaseName)
        {
            ConnectionString = connectionString;
            DatabaseName = databaseName;
        }

        public IMongoClient DatabaseClient => new MongoClient(ConnectionString);

        public IMongoDatabase Database =>
            DatabaseClient.GetDatabase(DatabaseName);
    }
}
