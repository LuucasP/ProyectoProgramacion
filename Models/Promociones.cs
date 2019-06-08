using System.ComponentModel.DataAnnotations;

namespace ProyProg.Models{

    public class Promociones {

        public int Id{get;set;}


        public string Foto{get;set;}
        [Required]
        public string Titulo{get;set;}
        [Required]
        public string Descripcion{get;set;}


        [Required]
        public string Precio{get;set;}
    }



}