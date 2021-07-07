﻿using Blog.Core.DataProvider.EntityFramework;
using Blog.Module.Posts.Contexts;

namespace Blog.Module.Categories.Repository
{
    public class BlogRepository<T> : EfRepository<T>, IBlogRepository<T> where T : class
    {
        public BlogRepository(BlogDbContext context) : base(context)
        {
        }
    }
}