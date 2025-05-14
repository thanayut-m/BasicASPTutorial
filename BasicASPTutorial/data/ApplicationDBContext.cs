using BasicASPTutorial.Modals;
using Microsoft.EntityFrameworkCore;

namespace BasicASPTutorial.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }

        public DbSet<Student> students { get; set; }

    }
}
