using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;

namespace MVC2.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AddDbContext _Context;

        public CinemasController(AddDbContext context)
        {
            _Context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allCinemas = await _Context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
