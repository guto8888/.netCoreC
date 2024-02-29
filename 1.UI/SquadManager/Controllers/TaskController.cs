using Microsoft.AspNetCore.Mvc;

namespace SquadManager.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}