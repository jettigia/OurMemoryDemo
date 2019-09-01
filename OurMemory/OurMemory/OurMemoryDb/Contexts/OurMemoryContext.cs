using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OurMemoryData.Entities;

namespace OurMemoryDb
{
    public class OurMemoryContext : IdentityDbContext
    {
        public OurMemoryContext(DbContextOptions<OurMemoryContext> options) : base(options) { }

        public DbSet<Memory> Memories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
