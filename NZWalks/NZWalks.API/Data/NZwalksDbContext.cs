using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZwalksDbContext: DbContext
    {
        public NZwalksDbContext(DbContextOptions<NZwalksDbContext> options):base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
