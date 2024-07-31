using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
