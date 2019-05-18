using System.ComponentModel.DataAnnotations;

namespace Base_de_Datos.Models
{
    public class Cliente
    {
        public int Id{get;set;}
        public string Foto{get;set;}

        [Required]
        public string Nombre{get;set;}
        public string ApellidoPat{get;set;}
        public string ApellidoMat{get;set;}
        public string DocumentoIden{get;set;}

        [Required]
        public string Email{get;set;}

        [Required]
        public string Pass{get;set;}
    }
}