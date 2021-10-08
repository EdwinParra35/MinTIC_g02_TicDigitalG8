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
    public class CategoriesController: ControllerBase
    {
        /*Inicializamos el apicationDbcontext*/
        private readonly ApplicationDbContext context;
        public CategoriesController(ApplicationDbContext context){
            this.context = context;
        }

        /* Tipo de solicitud del cliente: POST*/
        [HttpPost]
        /*La tarea retorna un int correspondiente al id de la categoria creada*/
        public async Task<ActionResult<int>> Post(Category category){
            /* con el metodo add agregamos el registro en la BD*/
            context.Add(category);
            /*Aplicamos los cambios en la BD, para guardar cambios de forma asincrona con el await*/
            await context.SaveChangesAsync();
            return category.Id;
        }
    }
}