using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

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
              Użytkownik match = _context.Users.FirstOrDefault(user => user.Email == rezerwacja.Email); 
                rezerwacja.użytkownik = match;
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
