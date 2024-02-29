using Microsoft.AspNetCore.Mvc;

namespace SquadManager.Controllers
{
    public class SquadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}