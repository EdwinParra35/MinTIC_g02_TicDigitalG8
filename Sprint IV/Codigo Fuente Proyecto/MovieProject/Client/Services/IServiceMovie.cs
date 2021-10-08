using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using MovieProject.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieProject.Client.Services
{
    /*  Las interfaces son abstractas, no implementan los metodos*/
    public interface IServiceMovie
    {
         List<Movie> GetMovies();
         Task<HttpResponseWrapper<object>> Post <T>(string url, T send);
    }
}