using Common;
using Microsoft.AspNetCore.Mvc;

namespace SquadManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Edit(PersonModel model)
        {
            return View(model ?? new PersonModel());
        }
    }
}