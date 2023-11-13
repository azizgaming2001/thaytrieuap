using Microsoft.EntityFrameworkCore;

namespace DEMO1.DBContext
{
    public class TrainerTestDBContext : DbContext
    {
        public TrainerTestDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TrainerTestRoles> Roles { get; set; }
    }
}
