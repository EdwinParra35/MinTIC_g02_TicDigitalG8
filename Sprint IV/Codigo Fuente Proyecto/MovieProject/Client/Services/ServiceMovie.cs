using System;
using MovieProject.Shared.Entity;
using System.Collections.Generic;

namespace MovieProject.Client.Services
{
    /* implementacion de una interfaz*/
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Moviename="Together",MovieImage="/Images/movie_1.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Kathapulta",MovieImage="/Images/movie_2.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="El Escuadron Suicida",MovieImage="/Images/movie_3.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Joker",MovieImage="/Images/movie_4.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Venom",MovieImage="/Images/movie_5.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Nuevas leyendas",MovieImage="/Images/movie_6.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Luca",MovieImage="/Images/movie_7.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Free Guy",MovieImage="/Images/movie_8.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Jungle Cruise",MovieImage="/Images/movie_9.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Kate",MovieImage="/Images/movie_10.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)}
            };
        }
    }
}