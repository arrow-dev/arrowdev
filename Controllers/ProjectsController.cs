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
        public class FeaturesController : Controller
    {
        private readonly ProjectDbContext context;

        public FeaturesController(ProjectDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/projects")]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            return await context.Projects.ToListAsync();
        }
    }
    }
}