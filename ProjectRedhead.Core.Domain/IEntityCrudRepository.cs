using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectRedhead.Core.Domain
{
    public interface IEntityCrudRepository<T> where T : Entity
    {
        Task<T> AddAsync(T entity);

        Task RemoveAsync(string id, bool softDelete = false);

        Task<T> GetAsync(string id);

        Task<T> GetOrAddByIdAsync(T entity);

        Task<IEnumerable<T>> GetAllAsync(int skip = 0, int take = -1);

        Task ReplaceAsync(string id, T newEntity);
    }
}
