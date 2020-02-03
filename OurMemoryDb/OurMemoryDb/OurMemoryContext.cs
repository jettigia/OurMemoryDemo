using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;

namespace OurMemoryDb
{
    public class OurMemoryContext : DbContext
    {
        public OurMemoryContext(DbContextOptions<OurMemoryContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<User>()
                .HasIndex(entity => entity.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(entity => entity.Username)
                .IsUnique();

            modelBuilder.Entity<Memory>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<Memory>()
                .HasOne(memoryEntity => memoryEntity.User)
                .WithMany(userEntity => userEntity.Memories)
                .HasForeignKey(memoryEntity => memoryEntity.UserId);

            modelBuilder.Entity<Comment>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<Comment>()
                .HasOne(entity => entity.Post)
                .WithMany(postEntity => postEntity.Comments)
                .HasForeignKey(postEntity => postEntity.PostId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
