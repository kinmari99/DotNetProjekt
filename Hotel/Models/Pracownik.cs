using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Pracownik
    {
        [Column(TypeName = "int")]

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(15)")]

        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        public string Surname { get; set; }

    
        [Column(TypeName = "nvarchar(50)")]

        public string Email { get; set; }


        public ICollection<Rezerwacja> Reservations { get; set; }
    }
}
