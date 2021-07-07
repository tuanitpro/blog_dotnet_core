namespace Blog.Module.Categories.Domain
{
    public class PostModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public string Slug { get; set; }

        public string FullText { get; set; }
    }
}