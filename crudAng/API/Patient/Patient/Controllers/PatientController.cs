using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient.Context;
using Patient.Helper;
using Patient.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientController( AppDbContext appDbContext)
        {
            _context = appDbContext;
        }



        
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Patients patientObj)
        {
            if(patientObj == null)
            {
                return BadRequest();
            }

            var patient = await _context.Patients.FirstOrDefaultAsync( x => x.Email == patientObj.Email );
            if(patient == null)
            {
                return NotFound(new { Message = "User not found !" });
            }

            if(!PAsswordHasher.VerifyPassword(patientObj.Password,patient.Password))
            {
                return BadRequest(new { Message = "Wrong Password " });
            }

            patient.Token = CreatejwtToken(patient);

            return Ok(new
            {    
                Token = patient.Token,
                Message = "Login Successful"
            }) ;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterPatient([FromBody] Patients patientObj)
        {
            if (patientObj == null)
            {
                return BadRequest();
            }
            //check username
            if(await ChechUserNameExitAsync(patientObj.Email))
            {
                return BadRequest(new { Message = "Email id allready exit ..." });
            }




            //check password Strength
            var pass = CheckPasswordStrenght(patientObj.Password); 
            if(!string.IsNullOrEmpty(pass))
            {
                return BadRequest(new { Message = pass.ToString() });
            }


            patientObj.Password = PAsswordHasher.HashPassword(patientObj.Password);
            patientObj.Token = "";
            await _context.Patients.AddAsync(patientObj);
            await _context.SaveChangesAsync();
            return Ok(new
            {
                Message = "Register Success !"
            });  

        }

        private   Task<bool> ChechUserNameExitAsync(string Email) => _context.Patients.AnyAsync(x => x.Email == Email);
        
        private string CheckPasswordStrenght(string password)
        {
            StringBuilder sb = new StringBuilder();
            if (password.Length < 8)
            {
                sb.Append("Minimum password length should be 8 : " + Environment.NewLine);
            }
            //if (Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[0-9]"))
            //{
            //    sb.Append("PAssword should be alphanumerics" + Environment.NewLine);
            //}
              return sb.ToString();
            
        }



        private string CreatejwtToken(Patients patient)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("veryverylongkeywith128bits......");
            var identity = new ClaimsIdentity( new Claim[]
                {
                new Claim (ClaimTypes.Email,$"{patient.Email}")
            });


            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var tokenDescripter = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            var token = jwtTokenHandler.CreateToken(tokenDescripter);
            return jwtTokenHandler.WriteToken(token);
            
        }
        [HttpGet]
        public async Task<ActionResult<Patients>> GetAllUsers()
        {
            return Ok(await _context.Patients.ToListAsync());
        }




    }
}
