using Microsoft.AspNetCore.Mvc;

namespace Course_Project.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("[action]")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult Course()
        {
            return View();
        }
    }
}
