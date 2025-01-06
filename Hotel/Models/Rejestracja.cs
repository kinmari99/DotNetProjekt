using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Rejestracja
    {
        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podaj Nazwisko")]
        [MinLength(2)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Proszę podaj login")]
        [MinLength(8)]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj Hasło. Minimum 8 znaków, 1 cyfra, 1 znak specjalny, 1 mała litera, 1 wielka.")]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d).*(?=.*[a-z]).*(?=.*[A-Z]).*)")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę powtórz Hasło")]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d).*(?=.*[a-z]).*(?=.*[A-Z]).*)")]
        [Compare(nameof(Haslo), ErrorMessage = ("Hasła różnią się"))]
        public string powtorzHaslo { get; set; }
    }
}
