namespace Blog.Module.Categories.Contexts
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int CreatedBy { get; set; }

        public System.DateTime CreatedOn { get; set; }
    }
}