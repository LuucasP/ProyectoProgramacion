using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacion.Models
{
    public class LoginCliente
    {
        
        [Required]

        public string Usuario{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}