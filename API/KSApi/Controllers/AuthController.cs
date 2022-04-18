using KSApi.Helpers;
using KSApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private readonly List<User> _users = new List<User>
        {
            new User
            {
                Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test",
            },
            new User
            {
                Id = 2, FirstName = "Test2", LastName = "User2", Username = "test2", Password = "test2",
            }
        };

        [HttpPost]
        public ActionResult<LoginResultModel> Login(LoginModel model)
        {
            var user = _users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user == null)
            {
                return NotFound(new
                {
                    message="Username or password is not correct"
                });
            }

            var token = GenerateJwtToken(user);
            return Ok(new LoginResultModel
            {
                UserID = user.Id,
                AuthToken = token
            });

        }

         private string GenerateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration["Jwt:SigningKey"]); //appsettings.json-daki jwt keyi


            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), //istifadecinin kimliyi
                new Claim(ClaimTypes.Name, user.FirstName),
            };


            var tokenDescriptor = new SecurityTokenDescriptor      //claimlari yaziriq
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = "example.com",
                Audience = "example.com",
                Expires = DateTime.UtcNow.AddHours(1), //istifade muddeti
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }



    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<string> Roles { get; set; } = new();
    }
}
