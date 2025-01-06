using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RezerwacjaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rezerwacja(Rezerwacja rezerwacja)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", rezerwacja);
            }
            else { return View("Index", rezerwacja); }
        }
        [HttpPost]
        public IActionResult Wynik(Rezerwacja rezerwacja)
        {
            return View(rezerwacja);
        }
    }
}
