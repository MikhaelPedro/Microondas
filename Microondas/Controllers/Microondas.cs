using Microsoft.AspNetCore.Mvc;

namespace Microondas.Controllers
{
    public class Microondas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
