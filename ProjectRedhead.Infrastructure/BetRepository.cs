using System;
using System.Collections.Generic;
using System.Text;
using ProjectRedhead.Core.Infrastructure;
using ProjectRedhead.Domain.BetAggregrate;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Infrastructure
{
    public class BetRepository : EntityCrudRepository<BetGame>, IBetRepository
    {
        public BetRepository(DatabaseProvider provider) : base(provider.Database)
        {
        }
    }
}
