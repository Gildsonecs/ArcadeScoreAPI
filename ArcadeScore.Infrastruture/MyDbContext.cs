using ArcadeScore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArcadeScore.Infrastruture
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Score> Score { get; set; }
    }
}
