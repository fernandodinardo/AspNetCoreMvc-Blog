using AspNetCore_Blog.Data.Mapping;
using AspNetCoreMvc_Blog.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace AspNetCore_Blog.Data
{
    public class BlogContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Post> Posts { get; set; }

        public BlogContext() 
            : base("MsSqlServer")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
