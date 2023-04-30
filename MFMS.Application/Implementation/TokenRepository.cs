using MFMS.Application.Repository;
using MFMS.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MFMS.Application.Implementation
{
    public class TokenRepository : ITokenRepository
    {
        private readonly IConfiguration _configuration;

        public TokenRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        Dictionary<string, string> UsersRecords = new Dictionary<string, string>
        {
            { "name","admin"},
            { "password","password"}
        };

        public Tokens Authenticate(Users users)
        {
            bool hasAdminPassword = UsersRecords.Any(x => x.Key == "name" && x.Value == users.Name || x.Key == "password" && x.Value == users.Password);
            bool hasAdminPassword1 = UsersRecords.ContainsKey("name") && UsersRecords["name"] == "admin" && UsersRecords.ContainsKey("password") && UsersRecords["password"] == "password";
            bool hasAdminPassword2 = UsersRecords.Any(x => x.Key == "name" && x.Value == "admin") && UsersRecords.Any(x => x.Key == "password" && x.Value == "password");
            bool hasAdminPassword3 = UsersRecords.Any(x => x.Key == "name" && x.Value == "admin" && UsersRecords.ContainsKey("password") && UsersRecords["password"] == "password");
            bool hasAdminPassword5 = UsersRecords["name"] == users.Name;
            bool hasAdminPassword6 = UsersRecords["password"] == users.Password;

            if (!UsersRecords.Any(x => x.Key == users.Name && x.Value == users.Password))
            {
                return null;
            }

            //Generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
             new Claim(ClaimTypes.Name, users.Name)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token) };
        }
    }
}
