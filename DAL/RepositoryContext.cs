using DAL.Configuration;
using DAL.Models;
using DAL.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public override int SaveChanges()
        {
            foreach(var entity in ChangeTracker.Entries().Where(p => p.State == EntityState.Added))
            {
                var created = entity.Entity as IEntityDate;
                if(created != null)
                {
                    created.CreateDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
