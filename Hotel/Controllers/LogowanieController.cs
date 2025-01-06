using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class LogowanieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logowanie(Logowanie logowanie)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", logowanie);
            }
            else { return View("Index", logowanie); }
        }
        [HttpPost]
        public IActionResult Wynik(Logowanie logowanie)
        {
            return View(logowanie);
        }
    }
}
