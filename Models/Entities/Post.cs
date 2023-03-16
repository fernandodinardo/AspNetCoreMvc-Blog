
namespace AspNetCoreMvc_Blog.Models.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Permalink { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedOn { get; set; }

        public Post()
        {
            PublishedOn = DateTime.Now;
        }
    }
}
