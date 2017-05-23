using arrowdev.Models;
using Microsoft.EntityFrameworkCore;

namespace arrowdev.Persistance
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options){
            
        }
    }
}