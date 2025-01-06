using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Logowanie
    {
        [Required(ErrorMessage = "Proszę podaj login")]
        [MinLength(8)]
        public string Nickname { get; set; }


        [Required(ErrorMessage = "Proszę podaj Hasło.")]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d).*(?=.*[a-z]).*(?=.*[A-Z]).*)")]
        public string Haslo { get; set; }
    }
}
