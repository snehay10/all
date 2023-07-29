using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
