using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;

namespace OurMemoryDb
{
    public class OurMemoryContext : DbContext
    {
        public OurMemoryContext(DbContextOptions<OurMemoryContext> options) : base(options) { }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>()
                .HasKey(entity => entity.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
