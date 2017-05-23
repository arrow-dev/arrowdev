using System.Collections.Generic;
using System.Threading.Tasks;
using arrowdev.Models;
using arrowdev.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace arrowdev.Controllers
{    
    public class ProjectsController : Controller
    {
        private readonly ProjectDbContext context;

        public ProjectsController(ProjectDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/projects")]
        public async Task<IActionResult> GetProjects()
        {
            var projects = await context.Projects.ToListAsync();
            return Ok (projects);
        }
    }    
}