using Hotel.Models;
using Microsoft.AspNetCore.Mvc;


namespace Hotel.Controllers
{
    public class LogowanieController : Controller
    {
        private static HotelsDBContext _context;
        public LogowanieController(HotelsDBContext context) { _context = context; }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logowanie(Logowanie logowanie)
        {
            if (ModelState.IsValid)
            {
                Użytkownik match = _context.Users.FirstOrDefault(user => user.Nickname == logowanie.Nickname && user.Haslo == logowanie.Haslo);
                
                if(match != null) { 
                    _context.SaveChanges();
                    return View("Wynik", logowanie);
                }
                else
                {
                    throw new Exception();
                }
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
