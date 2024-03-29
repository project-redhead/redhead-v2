﻿using System;
using MongoDB.Driver;
using ProjectRedhead.Core.Infrastructure;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Infrastructure
{
    public class UserRepository : EntityCrudRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseProvider provider) : base(provider.Database)
        {
        }
    }
}
