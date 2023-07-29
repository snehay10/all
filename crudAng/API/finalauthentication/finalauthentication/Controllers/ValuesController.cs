using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalauthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("Test")]
        public string GetData()
        {
            return "hello ...!";
        }
    }
}
