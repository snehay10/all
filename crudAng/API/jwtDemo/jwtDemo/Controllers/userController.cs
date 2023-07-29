using jwtDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace jwtDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {

        [HttpGet("Admin")]
        [Authorize(Roles =  "Admin")]
        public IActionResult AdminEndpoint()
        {
            var currentUSer = GetCorrentIdentity();
            return Ok($"Hi{currentUSer.UserName} , you are an {currentUSer.Role}");

        }

        [HttpGet("user")]
        [Authorize(Roles = "user")]
        public IActionResult UserEndpoint()
        {
            var currentUSer = GetCorrentIdentity();
            return Ok($"Hi{currentUSer.UserName} , you are an {currentUSer.Role}");

        }




        [HttpPost("public")]
        public IActionResult Public()
        {
            return Ok("hello ");
        }


        private user GetCorrentIdentity()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if(identity != null) 
            {
                var userclaim = identity.Claims;
                return new user
                {
                    UserName = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    Role = userclaim.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value,
                };
                  

            }

            return null;
        }
    }
}
