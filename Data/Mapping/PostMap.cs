using AspNetCoreMvc_Blog.Models.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetCore_Blog.Data.Mapping
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable("Posts");
            HasKey(x => x.Id);

            Property(x => x.Permalink)
                .HasMaxLength(100)
                .IsVariableLength()
                .IsRequired();

            Property(x => x.Title)
                .HasMaxLength(70)
                .IsVariableLength()
                .IsRequired();

            Property(x => x.Summary)
                .HasMaxLength(500)
                .IsVariableLength()
                .IsRequired();

            Property(x => x.Content)
                .IsMaxLength()
                .IsVariableLength()
                .IsOptional();
        }
    }
}
