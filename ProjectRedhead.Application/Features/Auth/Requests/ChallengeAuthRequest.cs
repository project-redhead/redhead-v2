using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Application.Features.Auth.Requests
{
    public class ChallengeAuthRequest : IRequest<IActionResult>
    {
        public string ProviderName { get; private set; }

        public string FinalizeReturnUrl { get; private set; }

        public ControllerBase Controller { get; private set; }

        public ChallengeAuthRequest(string providerName, string finalizeReturnUrl, ControllerBase controller)
        {
            ProviderName = providerName;
            FinalizeReturnUrl = finalizeReturnUrl;
            Controller = controller;
        }
    }
}
