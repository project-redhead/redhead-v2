using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Application.Features.User.Requests
{
    public class GetUserRequest : IRequest<IActionResult>
    {
        public string UserId { get; set; }

        public GetUserRequest(string userId)
        {
            UserId = userId;
        }
    }
}
