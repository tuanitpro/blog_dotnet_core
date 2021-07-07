namespace Blog.Module.Categories.Domain
{
    public class CategoryModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public string Slug { get; set; }

        public BlogModel Blog { get; set; }
    }
}