using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Application.Features.Auth.Requests
{
    public class ChallengeAuthRequest : IRequest<IActionResult>
    {
        public string ProviderName { get; private set; }

        public string ReturnUrl { get; private set; }

        public ControllerBase Controller { get; private set; }

        public ChallengeAuthRequest(string providerName, string returnUrl, ControllerBase controller)
        {
            ProviderName = providerName;
            ReturnUrl = returnUrl;
            Controller = controller;
        }
    }

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
