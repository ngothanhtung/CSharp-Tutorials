using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using OnlineShopApi.Models;

namespace OnlineShopApi.Services
{
    public interface IJwtService
    {
        string GenerateToken(string username);
    }

    public class JwtService : IJwtService
    {
        private readonly JwtConfig _jwtConfig;

        public JwtService(JwtConfig jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }

        public string GenerateToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Key));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Name, username),
                new(JwtRegisteredClaimNames.Sub, username),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            // Add roles
            //claims.Add(new Claim("roles", "Administrators"));
            claims.Add(new Claim("roles", "Managers"));
            claims.Add(new Claim("roles", "SuperUsers"));

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtConfig.ExpiryInMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}