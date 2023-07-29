using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;

namespace MVC2.Controllers
{
    public class MoviesController : Controller
    {

        private readonly AddDbContext _Context;

        public MoviesController(AddDbContext context)
        {
            _Context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allMovies = await _Context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}
