using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ProjectRedhead.Application.Data.Options
{
    public class RedheadSecurityOptions
    {
        public string SigningKey { get; set; } = "replacemepls!2019";

        public string Audience { get; set; } = "api.redhead.org";

        public string Issuer { get; set; } = "api.redhead.org";

        private TokenValidationParameters _tokenValidationParameters;
        public TokenValidationParameters TokenValidationParameters
        {
            get
            {
                _tokenValidationParameters = _tokenValidationParameters ?? new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SigningKey)),
                    ValidateIssuerSigningKey = true,

                    ValidateAudience = false,

                    ValidIssuer = Issuer,
                    ValidateIssuer = true,

                    ValidateLifetime = true,

                    RequireSignedTokens = true,
                    ClockSkew = TimeSpan.FromMinutes(5)
                };

                return _tokenValidationParameters;
            }
        }
    }
}