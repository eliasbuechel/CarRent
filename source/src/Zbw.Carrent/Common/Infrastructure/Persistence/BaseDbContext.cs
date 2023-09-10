using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public class BaseDbContext<T> : DbContext where T : Entity
    {
        public BaseDbContext(DbContextOptions<BaseDbContext<T>> options) : base(options)
        {}

        public DbSet<T> Elements { get; set; }
    }
}
