using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectRedhead.Application.Features.User.DataTransfer;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Application.Features.User.Requests
{
    public class GetUserRequestHandler : IRequestHandler<GetUserRequest, IActionResult>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserRequestHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetAsync(request.UserId);
            var dto = _mapper.Map<UserDto>(user);

            return new OkObjectResult(dto);
        }
    }
}