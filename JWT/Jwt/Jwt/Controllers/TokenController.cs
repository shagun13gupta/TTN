using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Jwt.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _config;
        private readonly LoginDBContext _context;

        public TokenController(IConfiguration config,LoginDBContext context)
        {
            _config = config;
            _context = context;
        }

        private Login GetUser(string username, string password)
        {
            return _context.Login.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
        [HttpPost]
        public IActionResult Detail(Login login)
        {
            var user = GetUser(login.UserName, login.Password);
            if (user != null)
            {               
                var claims = new[]
                {
                    new Claim(ClaimTypes.Role,user.Role)                                                                           

                };

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

               

                var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims:claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));


            }
            else
            {
                return BadRequest("Invalid Credentials");
            }
            
        }
       
    }
}