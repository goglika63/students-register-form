using GoglikaRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace GoglikaRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }  
        public DbSet<Student>Student { get; set; } 
    }
}
