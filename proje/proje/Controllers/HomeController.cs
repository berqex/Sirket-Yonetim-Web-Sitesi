using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
