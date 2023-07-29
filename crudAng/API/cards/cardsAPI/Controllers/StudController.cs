using cardsAPI.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cardsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudController : ControllerBase
    {
       // public readonly StudDbContext studDbContext;
        private readonly StudDbContext _studDbContext;

        public StudController(StudDbContext studDbContext)
        {
            _studDbContext = studDbContext;
        }
        [HttpGet]
        [Route("GetStudent")]
        public async Task<IEnumerable<stud>> GetStuds()
        {
            return await _studDbContext.stud.ToListAsync();

        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<stud> AddStudent(stud objstud) 
        {
            _studDbContext.stud.Add(objstud);
            await _studDbContext.SaveChangesAsync();
            return objstud;
        }

        [HttpPatch]
        [Route("UpdateStude/{id}")]

        public async Task<stud> UpdateStud(stud objstud)
        {
            _studDbContext.Entry(objstud).State = EntityState.Modified;
            await _studDbContext.SaveChangesAsync();
            return objstud;
        }

        [HttpDelete]
        [Route("zd")]

    }
}
