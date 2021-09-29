using First_Traning.Controllers.model;
using First_Traning.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.Controllers.models
{
    public class AppDBContext : DbContext
    {
        private object builder;

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
     //       modelBuilder.Entity<User>(entity => {
     //       entity.HasMany<Post>().WithOne(post => post.Users).HasForeignKey(post => post.userId).OnDelete(DeleteBehavior.Restrict);
     //       )};
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
