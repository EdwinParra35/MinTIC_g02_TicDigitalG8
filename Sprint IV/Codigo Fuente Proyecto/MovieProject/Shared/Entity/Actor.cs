using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace MovieProject.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string ActorName{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public DateTime? BirthDate{get;set;}
        public string Photo {get;set;}
        public int KnowCredits {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Biography {get;set;}
        public int Nominations {get;set;}
        /* Relacion de muchos a muchos */
        public List<MovieActor> MoviesActor {get;set;}
    }
}