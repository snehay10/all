using jwtDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.CodeDom.Compiler;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace jwtDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] userlogin userlogin)
        {
            var user = Authenticate(userlogin);

            if(user != null)
            {
                var token = Generate(user);
                return Ok(new {token});
            }
            return Ok("user not found");
        }


        private string Generate(user user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:Key"]));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
               new Claim(ClaimTypes.NameIdentifier, user.UserName),
               new Claim(ClaimTypes.Role, user.Role)
            };


            var token = new JwtSecurityToken(
               
                
                _configuration["jwt:Issuer"],
                _configuration["jwt:Audiance"],
                claims,
                expires:DateTime.Now.AddMinutes(5),


                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }



        private user Authenticate(userlogin userlogin)
        {
            var currentUser = userconstants.User.FirstOrDefault(o => o.UserName.ToLower() == userlogin.UserName.ToLower() && o.Password == userlogin.Password);
            if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }
    }
}
