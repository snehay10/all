using Hospital.models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class PatientController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly PatientContext _context;
        public PatientController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost("CreatePatient")]

        public IActionResult Create(patient patient)
        {
            if(_context.patient.Where(pe =>pe.Email == patient.Email).FirstOrDefault() !=null)
            {
                return Ok("already");
            }
                patient.registrationDate=DateTime.Now;
                _context.patient.Add(patient);
                _context.SaveChanges();
                return Ok("success");
        }

        }
}
