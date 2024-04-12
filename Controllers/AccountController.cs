using Microsoft.AspNetCore.Mvc;

namespace Course_Project.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Login(LoginRequestDTO loginrequest)
        {
            return View();
        }
    }
}
