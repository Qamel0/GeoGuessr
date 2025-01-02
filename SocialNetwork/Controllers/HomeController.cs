using Microsoft.AspNetCore.Mvc;

namespace GeoGuessr.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
