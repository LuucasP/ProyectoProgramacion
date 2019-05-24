using System;
using System.ComponentModel.DataAnnotations;

namespace ProyProg.Models{

    public class Cliente{

        public int Id{get;set;}


        public string Foto{get;set;}
        [Required]
        public string Nombre{get;set;}
        [Required]
        public string Apepat{get;set;}


        [Required]
        public string Apemat{get;set;}
        [Required]
        public string Dni{get;set;}

        [Required]        
        public string Email{get;set;}
        [Required]
        public string Pass{get;set;}



    }
}