using Microsoft.AspNetCore.Mvc;

namespace Task16Ogani.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
