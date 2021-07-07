namespace Blog.Module.Core.Logger
{
    public interface ILogActivity
    {
        public string ActionType { get; set; }

        public string Message { get; set; }
    }
}