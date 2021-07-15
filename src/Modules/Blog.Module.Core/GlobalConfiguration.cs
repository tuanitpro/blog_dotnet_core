using System.Collections.Generic;

namespace Blog.Module.Core
{
    public static class GlobalConfiguration
    {
        public static IList<ModuleInfo> Modules { get; set; } = new List<ModuleInfo>();
    }
}