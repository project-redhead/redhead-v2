using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectRedhead.Application.Features.Auth.Requests;

namespace ProjectRedhead.Application.Features.Auth
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("challenge/discord")]
        public async Task<IActionResult> ChallengeDiscord([FromQuery] string returnUrl = "")
        {
            return await _mediator.Send(new ChallengeAuthRequest("discord", 
                Url.Action(nameof(ChallengeCallback), new { returnUrl }), this));
        }

        public async Task<IActionResult> ChallengeCallback([FromQuery] string returnUrl = "")
        {
            throw new NotImplementedException();
        }
    }
}
