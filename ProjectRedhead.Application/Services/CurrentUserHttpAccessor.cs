using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjectRedhead.Application.Services
{
    public class CurrentUserHttpAccessor : ICurrentUserAccessor
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public CurrentUserHttpAccessor(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUserId()
        {
            return _contextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
