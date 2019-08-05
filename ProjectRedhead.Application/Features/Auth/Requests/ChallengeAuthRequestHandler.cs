using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Application.Features.Auth.Requests
{
    public class ChallengeAuthRequestHandler : IRequestHandler<ChallengeAuthRequest, IActionResult>
    {
        public Task<IActionResult> Handle(ChallengeAuthRequest request, CancellationToken cancellationToken)
        {
            var action = request.Controller.Challenge(new AuthenticationProperties()
            {
                RedirectUri = request.ReturnUrl
            }, request.ProviderName);

            return Task.FromResult<IActionResult>(action);
        }
    }
}