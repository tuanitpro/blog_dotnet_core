namespace Blog.Modules.Shared
{
    public class ParamQueryModel
    {
        public string Keyword { get; set; }

        public int Take { get; set; }

        public int Skip { get; set; }
    }
}