using Microsoft.EntityFrameworkCore;

namespace oneToMeny.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Teacher> Teachers {get;set;}
        public DbSet<Student> Students {get;set;}
    }
}
