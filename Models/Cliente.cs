using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra1.Models{

    public class Cliente{

        public int Id {get; set;}

        [Required]
        public int Dni{get; set;}

        public string Nombre {get;set;}

        public string Apepat {get; set;}

        public string Apemat {get;set;}

        [Required]

        public LoginCliente Correo {get; set;}

        [Required]

        public LoginCliente Contraseña {get; set;}


    }
}