using Microsoft.EntityFrameworkCore;
using ZooApi.Models;

namespace ZooApi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AnimalModel> Animals { get; set; }
    }
}
