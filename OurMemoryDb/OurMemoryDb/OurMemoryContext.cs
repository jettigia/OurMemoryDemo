﻿using Microsoft.EntityFrameworkCore;
using OurMemory.Entities;

namespace OurMemoryDb
{
    public class OurMemoryContext : DbContext
    {
        public OurMemoryContext(DbContextOptions<OurMemoryContext> options) : base(options) { }
        public DbSet<CommentEntity> CommentEntities { get; set; }
        public DbSet<PostEntity> PostEntities { get; set; }
        public DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<PostEntity>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<CommentEntity>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<CommentEntity>()
                .HasOne(entity => entity.Post)
                .WithMany(postEntity => postEntity.Comments)
                .HasForeignKey(postEntity => postEntity.PostId);

            base.OnModelCreating(modelBuilder);
        }
    }
}