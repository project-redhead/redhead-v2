﻿using System;
using System.Collections.Generic;
using System.Text;
using ProjectRedhead.Core.Domain;

namespace ProjectRedhead.Domain.BetAggregrate
{
    public interface IBetRepository : IEntityCrudRepository<BetGame>
    {
    }
}
