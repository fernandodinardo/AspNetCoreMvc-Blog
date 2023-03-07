using AspNetCoreMvc_Blog.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc_Blog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base ("MsSqlServer")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
