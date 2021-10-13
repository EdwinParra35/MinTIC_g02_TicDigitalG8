using System.Threading;
using MovieProject.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Server.Storage;

namespace MovieProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "movies";


        public MoviesController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie){
            if (!string.IsNullOrWhiteSpace(movie.MovieImage))
            {
                var movie_poster = Convert.FromBase64String(movie.MovieImage);
                movie.MovieImage = await FilesStorage.SaveFile(movie_poster,".jpg", carpeta);
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.id;
        }
        
    }
}