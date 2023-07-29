using DbownDemo.Data;
using DbownDemo.Models;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace DbownDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly DemoDbContext _context;
        private readonly IConfiguration _configuration;

        public UserController(DemoDbContext context,IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        //insert data
        [HttpPost("registration")]
        public async Task<IActionResult>  Inregistrationdex(User Objuser)
        {
            try
            {
                if (Objuser == null)
                {
                    return BadRequest();
                }


                if (await checkEmailExitst(Objuser.mobile))
                {
                    return BadRequest("Mobile already Exit");
                }


                _context.Add(Objuser);
                _context.SaveChanges();
                return Ok("Done ...!");


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
       
        //check mobile exit or not
        private Task<bool> checkEmailExitst(string mobile) => _context.users.AnyAsync(x => x.mobile == mobile);
        //display all users

        [HttpPost("view")]
        public IActionResult view()
        {
            try
            {
                var userList = _context.users.ToList();
                if(userList.Count == 0)
                {
                    return BadRequest("No user is found....!");
                }

                return Ok(userList);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //specific user data 
        [HttpPost("specificuser")]
        public IActionResult specificuser(int id)
        {
            try
            {
                var userofid = _context.users.Find(id);
                if (userofid == null) 
                {
                    return NotFound("User not Found...!");
                }
                return Ok(userofid);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //delete user data
        [HttpDelete("Delete")]
        public IActionResult delete(int id)
        {
            var user1 = _context.users.Find(id);
            if(user1 == null)
            {
                return NotFound("user not found");
            }
            _context.users.Remove(user1);
            _context.SaveChanges();
            return Ok("User deleted....!");     
        }


        // //update  user data
        // [HttpPut("update")]
        //// public IActionResult update(int id) 
        // {
        //     try
        //     {
        //         var userdto = 
        //        // var userid = _context.users.Find(userdto.id);
        //         if(userid == null)
        //         {
        //             return NotFound("user not found...");
        //         }

        //         userid.name = userdto.name;
        //         userid.password = userdto.password;
        //         userid.role = userdto.role;
        //         userid.name = userdto.name;
        //         _context.SaveChanges();
        //         return Ok("updated ...!");
        //     }
        //     catch(Exception ex) 
        //     {
        //         return BadRequest(ex.Message);

        //     }
        // }

        [HttpPost("DTo1234")]
        public  IActionResult  DTo1234(UserDTO userDTO)
        {
            try
            {

                string mobile = userDTO.Mobile;
                string pass = userDTO.Password;
                string role = userDTO.Role;

                var user = _context.users.FirstOrDefault(u => u.mobile== mobile  && u.password == pass && u.role == role);
                if (user == null)
                {
                    return NotFound("user is not present ");
                }
                return Ok("user logged ");
            }
            catch(Exception ex)
            { 
                return BadRequest(ex.Message); 
            }


           
        }


        //login
        [HttpPost("Login")]
        public IActionResult Login(int id ,string password)
        {
            var useritem = _context.users.Find(id);
            if (useritem != null)
            {
                if (useritem.password == password)
                {
                    return Ok("Login done ....1");
                }
                return BadRequest("invalide Password ");
            }
            return NotFound("user not found ..........!");
        }

        //token Generation
        [HttpPost("Token")]
        public string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:Key"]));
            var cradiantial = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var claims = new[] 
            {
                new Claim(ClaimTypes.MobilePhone,user.mobile),
                new Claim(ClaimTypes.Role,user.role),
            };

            var token = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: cradiantial

                ) ;

            return new JwtSecurityTokenHandler().WriteToken(token); 
        }


    }
}
