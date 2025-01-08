using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RezerwacjaController : Controller
    {
        private static HotelsDBContext _context;
        public RezerwacjaController(HotelsDBContext context) { _context = context; }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rezerwacja(Rezerwacja rezerwacja)
        {
            if (ModelState.IsValid)
            {
                _context.Reservations.Add(rezerwacja);
                _context.SaveChanges();
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
