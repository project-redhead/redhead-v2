using AutoMapper;

namespace ProjectRedhead.Core.Domain
{
    public class DomainProfile : Profile
    {
        public (IMappingExpression<T, Z> In, IMappingExpression<Z, T> Out) CreateTwoWayMap<T, Z>()
        {
            return (CreateMap<T, Z>(MemberList.Destination), CreateMap<Z, T>(MemberList.Source));
        }
    }
}
