using Microsoft.AspNetCore.Mvc;

namespace UniverseGames.API.Controllers
{
    public class ImagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
