using System;
using System.Collections.Generic;
using movieProyec.Shared.Entity;
namespace movieProyec.Client.Services
{
    public class Service:IService
    {
       public public class IService
       {
           public List<Movie> GetMovies(){
               return new List<Movie>(){
                    new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/Accion/movie_6.jpg",CurrentMovie= new DateTime(2021,09,18)},
                    new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/Accion/movie_7.jpg",CurrentMovie= new DateTime(2021,09,18)},
                    new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/Accion/movie_8.jpg",CurrentMovie= new DateTime(2021,09,18)},
                    new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/Accion/movie_9.jpg",CurrentMovie= new DateTime(2021,09,18)},
                    new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/Accion/movie_10.jpg",CurrentMovie= new DateTime(2021,09,18)}

                };
           }
       } 
    }
}