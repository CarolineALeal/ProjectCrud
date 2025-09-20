using System.ComponentModel.DataAnnotations;

namespace ProjectCrud.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "E-mail é obrigatório!")]
        public string Email { get; set; }
    }
}