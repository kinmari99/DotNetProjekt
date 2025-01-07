using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Newsletter
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email {  get; set; }

        [Display(Name = "Wyrażam zgodę na przetwarzanie moich danych przez Hotel XYZ")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz wyrazić zgodę.")]
        public bool IsAccepted { get; set; }
    }
}
