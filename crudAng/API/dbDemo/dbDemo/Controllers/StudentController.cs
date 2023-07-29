using dbDemo.Data;
using dbDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dbDemo.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class StudentController : Controller
    {
        private readonly dbDemoDbContext _dbDemoDbContext;
        public StudentController(dbDemoDbContext dbDemoDbContext)
        {
            _dbDemoDbContext = dbDemoDbContext;
        }
        //display
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
          var students= await  _dbDemoDbContext.Students.ToListAsync();
            return Ok(students);
        }

        //add student
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] student studentRequest)
        {
            studentRequest.id = Guid.NewGuid();
            await  _dbDemoDbContext.Students.AddAsync(studentRequest);
            await _dbDemoDbContext.SaveChangesAsync();
            return Ok(studentRequest);
        }


    }
}
