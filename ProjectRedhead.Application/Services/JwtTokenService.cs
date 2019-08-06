using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjectRedhead.Application.Data.Options;

namespace ProjectRedhead.Application.Services
{
    public class JwtTokenService
    {
        private RedheadSecurityOptions _securityOptions;

        public JwtTokenService(IOptions<RedheadSecurityOptions> securityOptions)
        {
            _securityOptions = securityOptions.Value;
        }

        public string WriteToken(string userId, string issuer)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_securityOptions.SigningKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,

                Subject = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userId)
                }),

                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
