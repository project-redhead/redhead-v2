using System;
using System.Collections.Generic;
using System.Text;
using ProjectRedhead.Core.Domain;

namespace ProjectRedhead.Domain.UserAggregrate
{
    public interface IUserRepository : IEntityCrudRepository<User>
    {
    }
}
