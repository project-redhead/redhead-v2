using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectRedhead.Application.Features.User.DataTransfer;
using ProjectRedhead.Application.Features.User.Requests;
using ProjectRedhead.Application.Services;

namespace ProjectRedhead.Application.Features.User
{
    [Route("user")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICurrentUserAccessor _userAccessor;

        public UserController(IMediator mediator, ICurrentUserAccessor userAccessor)
        {
            _mediator = mediator;
            _userAccessor = userAccessor;
        }

        [HttpGet]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetCurrentUserAsync()
        {
            return await _mediator.Send(new GetUserRequest(_userAccessor.GetUserId()));
        }
    }
}