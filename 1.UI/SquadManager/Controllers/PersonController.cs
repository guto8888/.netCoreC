using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;

namespace SquadManager.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(PersonViewModel model = null)
        {
            return View(model ?? new PersonViewModel());
        }

        public IActionResult Edit(PersonViewModel model = null)
        {
            return View(model ?? new PersonViewModel());
        }
    }
}