using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
