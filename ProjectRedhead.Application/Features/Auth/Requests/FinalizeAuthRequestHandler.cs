using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.IdentityModel.Tokens;
using ProjectRedhead.Application.Exceptions;
using ProjectRedhead.Application.Services;
using ProjectRedhead.Domain.UserAggregrate;

namespace ProjectRedhead.Application.Features.Auth.Requests
{
    public class FinalizeAuthRequestHandler : IRequestHandler<FinalizeAuthRequest, IActionResult>
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtTokenService _tokenService;

        public FinalizeAuthRequestHandler(IUserRepository userRepository, JwtTokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<IActionResult> Handle(FinalizeAuthRequest request, CancellationToken cancellationToken)
        {
            // Gather external data
            var externalId = request.Context?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var externalName = request.Context?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;

            // Check
            if (string.IsNullOrEmpty(externalId) || string.IsNullOrEmpty(externalName))
                throw new StatusException(400, "Bad request", "No external user was found in the current request");

            // Get user
            var user = await _userRepository.GetOrAddByIdAsync(new User(externalId, externalName, UserRole.Member));
            
            // Write JWT
            var jwt = _tokenService.WriteToken(user.Id, request.Context.Request.Host.Host);

            var redirect = QueryHelpers.AddQueryString(request.RedirectUrl, "token", jwt);
            return new RedirectResult(redirect);
        }
    }
}