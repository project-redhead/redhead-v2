using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectRedhead.Application.Features.Auth.Requests
{
    public class FinalizeAuthRequest : IRequest<IActionResult>
    {
        public HttpContext Context { get; set; }

        public string RedirectUrl { get; set; }

        public FinalizeAuthRequest(HttpContext context, string redirectUrl)
        {
            Context = context;
            RedirectUrl = redirectUrl;
        }
    }
}
