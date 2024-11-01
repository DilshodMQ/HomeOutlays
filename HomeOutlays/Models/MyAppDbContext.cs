using Microsoft.EntityFrameworkCore;

namespace HomeOutlays.Models
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        public DbSet<Outlay> Outlays { get; set; }
    }
}
