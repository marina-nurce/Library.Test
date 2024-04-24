using Microsoft.EntityFrameworkCore;

namespace Library.API
{
    public class AppDbContext:DbContext
    {
        //krijojme konstruktorin
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        

        {

        }
        public DbSet<Models.Books>Books { get; set; }
    }

}
