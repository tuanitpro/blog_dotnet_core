using System;
using System.Reflection;

namespace Blog.Module.Core
{
    public class ModuleInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Version Version { get; set; }

        public Assembly Assembly { get; set; }
    }
}