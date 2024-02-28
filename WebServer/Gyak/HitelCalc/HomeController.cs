using Microsoft.AspNetCore.Mvc;

namespace WebServer.Gyak.HitelCalc
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
