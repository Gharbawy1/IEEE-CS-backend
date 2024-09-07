using Microsoft.AspNetCore.Mvc;

namespace Task3._2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
