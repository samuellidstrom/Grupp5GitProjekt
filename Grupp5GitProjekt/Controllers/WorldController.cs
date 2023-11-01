using Microsoft.AspNetCore.Mvc;

namespace Grupp5GitProjekt.Controllers
{
    public class WorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
