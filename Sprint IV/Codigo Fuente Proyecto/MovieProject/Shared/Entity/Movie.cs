using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
namespace MovieProject.Shared.Entity
{
    public class Movie
    {
       public int id {get;set;} 
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string  Moviename{get;set;}
       public bool EnCartelera {get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string  Sinopsis{get;set;}
       public string  MovieImage{get;set;}
       [Required (ErrorMessage ="El campo {0} es requerido")]
       public DateTime  Premier{get;set;}
       public int  Score{get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string Trailer{get;set;}
       [Required (ErrorMessage ="El campo {0} es requerido")]
       public List <CategoryMovie> CategoriesMovie {get;set;} = new List <CategoryMovie> ();
       public string ShortName
        {
            get{
               if (string.IsNullOrWhiteSpace(MovieImage))
               {
                   return null;
               }
               if (MovieImage.Length > 60){
                   return MovieImage.Substring(0,60) + "...";
               }else{
                   return MovieImage;
               }
            }
        } 
    }
}