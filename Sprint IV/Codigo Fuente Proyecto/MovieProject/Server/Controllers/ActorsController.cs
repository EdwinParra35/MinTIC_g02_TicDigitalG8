using MovieProject.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovieProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ActorsController: ControllerBase
    {   
        private readonly ApplicationDbContext context;
        public ActorsController(ApplicationDbContext context){
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor){
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var actor_photo = Convert.FromBase64String(actor.Photo);
            }

            context.Add(actor);            
            await context.SaveChangesAsync();
            return actor.Id;
        }
    }
}