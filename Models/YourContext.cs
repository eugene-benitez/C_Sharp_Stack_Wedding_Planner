using Microsoft.EntityFrameworkCore;
//CHANGE THIS
namespace Wedding_Planner.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        // "users" table is represented by this DbSet "Users"
        public DbSet<User> User { get; set; }
        public DbSet<Wedding> Wedding { get; set; }

        public DbSet<RSVP> RSVP { get; set; }
    }
}
