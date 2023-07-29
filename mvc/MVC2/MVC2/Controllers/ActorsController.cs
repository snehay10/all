using Microsoft.AspNetCore.Mvc;
using MVC2.Data;

namespace MVC2.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AddDbContext _Context;

        public ActorsController(AddDbContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            var data = _Context.Actors.ToList();
            return View(data);
        }
    }
}
