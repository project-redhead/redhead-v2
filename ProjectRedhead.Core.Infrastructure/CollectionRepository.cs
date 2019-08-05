using MongoDB.Driver;

namespace ProjectRedhead.Core.Infrastructure
{
    public abstract class CollectionRepository<T>
    {
        internal readonly IMongoDatabase Database;

        protected CollectionRepository(IMongoDatabase database)
        {
            Database = database;
        }

        public IMongoCollection<T> GetCollection() => Database.GetCollection<T>(typeof(T).FullName);
    }
}