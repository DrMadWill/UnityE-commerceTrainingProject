using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UnityETP.Entity.Users;

namespace UnityETP.API.Helpers
{
    public class ApiToken
    {
        public const int TokenLifetime = 60; // Minutes
        public static TokenValidationParameters CreateTokenValidationParameters(string issuer,string audience,string secretKey)
        {
            return new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = issuer,
                ValidateAudience = true,
                ValidAudience = audience,
                ValidateLifetime = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuerSigningKey = true
            };
        }

        public static string CreateToken(string userId,string role,string userName, string issuer, string audience, string secretKey)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new Claim[]
            {
                new Claim("Id",userId),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.Name, userName)
            };

            var token = new 
                JwtSecurityToken(
               issuer, audience,
              claims,expires: DateTime.Now.AddMinutes(TokenLifetime),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        




    }
}
