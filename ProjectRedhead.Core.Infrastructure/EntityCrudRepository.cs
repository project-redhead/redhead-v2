using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;
using ProjectRedhead.Core.Domain;
using IMongoDatabase = MongoDB.Driver.IMongoDatabase;

namespace ProjectRedhead.Core.Infrastructure
{
    public abstract class EntityCrudRepository<T> : CollectionRepository<T>, IEntityCrudRepository<T> where T : Entity
    {
        protected EntityCrudRepository(IMongoDatabase database) : base(database)
        {
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            var id = Guid.NewGuid().ToString();
            entity.Id = id;

            await GetCollection().InsertOneAsync(entity);

            return await GetAsync(id);
        }

        public virtual async Task RemoveAsync(string id, bool softDelete = false)
        {
            Expression<Func<T, bool>> filter = entity => entity.Id == id;

            if (!softDelete)
            {
                await GetCollection().FindOneAndDeleteAsync(filter);
            }
            else
            {
                var update = Builders<T>.Update.Set(entity => entity.DeletedAt, DateTime.Now);
                await GetCollection().FindOneAndUpdateAsync(filter, update);
            }
        }

        public virtual async Task<T> GetAsync(string id)
        {
            var item = await GetCollection().FindAsync(r => r.Id == id);
            return await item.SingleOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(int skip = 0, int take = -1)
        {
            var results = await GetCollection().FindAsync(entity => !string.IsNullOrEmpty(entity.Id));
            var list = await results.ToListAsync();

            return list
                .Skip(0)
                .Take(take == -1 ? int.MaxValue : take);
        }

        public virtual async Task ReplaceAsync(string id, T newEntity)
        {
            await GetCollection().ReplaceOneAsync(entity => entity.Id == id, newEntity);
        }
    }
}
