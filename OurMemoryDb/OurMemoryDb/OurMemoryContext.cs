using Microsoft.EntityFrameworkCore;
using OurMemoryDb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OurMemoryDb
{
    public class OurMemoryContext : DbContext
    {
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
