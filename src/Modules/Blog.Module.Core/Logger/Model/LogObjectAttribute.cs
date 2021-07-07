using System;

namespace Blog.Module.Core.Logger
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
    public class LogObjectAttribute : Attribute
    {
        public string ObjectName { get; set; }
    }
}