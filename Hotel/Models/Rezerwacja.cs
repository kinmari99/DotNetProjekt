using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Rezerwacja
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podaj Nazwisko")]
        [MinLength(2)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Proszę podaj numer dowodu tożsamości")]
        [MaxLength(15)]

        public string IDCard { get; set; }

        [Required(ErrorMessage = "Proszę podaj miejsce zamieszkania")]
        [MaxLength(30)]
        public string City { get; set; }

        [Required(ErrorMessage = "Proszę podaj miejsce ulicę")]
        [MaxLength(30)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Proszę podaj numer budynku")]

        public string Building { get; set; }
        

        public string? Apartment { get; set; } 


        [Required(ErrorMessage = "Proszę podaj kod pocztowy")]
        [MaxLength(6)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Proszę podaj pocztę")]
        [MaxLength(30)]
        public string PostOffice { get; set; }



        [Required(ErrorMessage = "Proszę podaj liczbę pokoi. Minimalnie możesz zarezerwować 1 pokój, maksymalnie 12")]
        [Range(1, 12)]
        public int? HowManyRooms { get; set; } = 1;
        [Required(ErrorMessage = "Proszę podaj liczbę łóżek. Minimalnie możesz zarezerwować 1 łóżko, maksymalnie 30")]
        [Range(1, 30)]
        public int? HowManyBeds { get; set; } = 1;

     



    }
}
