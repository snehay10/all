using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;

namespace MVC2.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AddDbContext _Context;

        public ProducersController(AddDbContext context)
        {
            _Context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _Context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
