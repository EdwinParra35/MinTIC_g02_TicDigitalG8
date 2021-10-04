using MovieProject.Shared.Entity;
using System.Collections.Generic;
namespace MovieProject.Client.Services
{
    /*  Las interfaces son abstractas, no implementan los metodos*/
    public interface IServiceMovie
    {
         List<Movie> GetMovies();
    }
}