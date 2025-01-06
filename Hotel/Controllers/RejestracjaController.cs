using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RejestracjaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rejestracja(Rejestracja rejestracja)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", rejestracja);
            }
            else { return View("Index", rejestracja); }
        }
        [HttpPost]
        public IActionResult Wynik(Rejestracja rejestracja)
        {
            return View(rejestracja);
        }
    }
}
