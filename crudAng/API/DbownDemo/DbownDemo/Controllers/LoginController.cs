using AutoMapper;
using DbownDemo.Data;
using DbownDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DbownDemo.Controllers
{
    [Route("api/[Controller]")]
    public class LoginController : Controller
    {
        private IConfiguration _configuration;
        private DemoDbContext _demoDbContext;
      




        public LoginController(IConfiguration configuration, DemoDbContext demoDbContext )
        {
            _configuration = configuration;
            _demoDbContext = demoDbContext;
                
        }

        [AllowAnonymous]
        [HttpPost("Login")]
       
        public IActionResult Login([FromBody] userLogin userlogin)
        {
            var user = Authenticate(userlogin);

            if (user != null)
            {
                var token = Generate(user);
                return Ok( token );
            }
            return Ok("user not found");
        }




        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("JWT:Key"));
            var credintial = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Claims = new[] {

            new Claim(ClaimTypes.Name,user.mobile),
            new Claim(ClaimTypes.NameIdentifier, user.name),
            new Claim(ClaimTypes.Role, user.role)
            
            };

            var token = new JwtSecurityToken(

                _configuration["JWT:Issuer"],
                _configuration["JWT: Audiance"],
                Claims,
                expires: DateTime.Now.AddMinutes(4),
                signingCredentials: credintial);
                return new JwtSecurityTokenHandler().WriteToken(token);
        }

    
    
        private User Authenticate(userLogin user) 
        {
             var currentUser = _demoDbContext.users.FirstOrDefault( o => o.mobile.ToLower() == user.mobile.ToLower() &&  o.password == user.password);
             if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }

  
    }
}
