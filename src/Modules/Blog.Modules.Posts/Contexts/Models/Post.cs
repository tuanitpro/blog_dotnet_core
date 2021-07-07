namespace Blog.Module.Posts
{
    public class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public string Slug { get; set; }

        public string FullText { get; set; }

        public int CreatedBy { get; set; }

        public System.DateTime CreatedOn { get; set; }

        public int BlogId { get; set; }
    }
}