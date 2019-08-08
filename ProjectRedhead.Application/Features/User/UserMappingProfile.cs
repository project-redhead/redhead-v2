using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectRedhead.Application.Features.User.DataTransfer;
using ProjectRedhead.Core.Domain;

namespace ProjectRedhead.Application.Features.User
{
    public class UserMappingProfile : DomainProfile
    {
        public UserMappingProfile()
        {
            CreateTwoWayMap<Domain.UserAggregrate.User, UserDto>();
        }
    }
}
