using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public class BaseDbContext<T> : DbContext where T : Entity
    {
        public BaseDbContext(DbContextOptions<BaseDbContext<T>> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<T> Elements { get; set; }
    }
}
