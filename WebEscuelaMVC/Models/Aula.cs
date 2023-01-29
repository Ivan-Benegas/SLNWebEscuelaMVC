using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEscuelaMVC.Validations;

namespace WebEscuelaMVC.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckValidNumberAttribute]
        public string Estado { get; set; }

    }
}
