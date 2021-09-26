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
                new Movie(){Moviename="Movie 1",MovieImage="/Images/movie_1.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 2",MovieImage="/Images/movie_2.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 3",MovieImage="/Images/movie_3.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 4",MovieImage="/Images/movie_4.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 5",MovieImage="/Images/movie_5.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 6",MovieImage="/Images/movie_6.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 7",MovieImage="/Images/movie_7.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 8",MovieImage="/Images/movie_8.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 9",MovieImage="/Images/movie_9.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Movie 10",MovieImage="/Images/movie_10.jpg",Sinapsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)}
            };
        }
    }
}