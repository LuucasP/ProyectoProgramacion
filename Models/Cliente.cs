using System;
using System.ComponentModel.DataAnnotations;

namespace ProyProg.Models{

    public class Cliente{

        [Required]
        public string Nombre {get;set;}

        [Required]
        public string Apellido{get;set;}

        [Required]
        public string Fecnac{get;set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}

        [Required]
        public string Usuario{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}


        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas deben de ser iguales")]
        public string PasswordConfirmacion {get;set;}

    }
}