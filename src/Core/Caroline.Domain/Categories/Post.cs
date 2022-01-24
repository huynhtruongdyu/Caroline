using Caroline.Domain.Auditable;

namespace Caroline.Domain.Categories
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }
    }
}