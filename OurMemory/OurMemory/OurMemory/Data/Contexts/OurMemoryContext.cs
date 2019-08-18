using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OurMemory.Data.Entities;

namespace OurMemory.Data
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
