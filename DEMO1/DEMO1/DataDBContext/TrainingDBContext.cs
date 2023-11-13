
using Microsoft.EntityFrameworkCore;

namespace DEMO1.DataDBContext
{
    public class TrainingDBContext : DbContext
    {
        public TrainingDBContext(DbContextOptions<TrainingDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories{ get; set; }
    }
}
