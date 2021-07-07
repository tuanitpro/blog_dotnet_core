using Microsoft.EntityFrameworkCore;

namespace Blog.Module.Posts.Contexts
{
    public partial class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog.Module.Posts.Post>(entity =>
            {
                entity.ToTable("Posts");
                entity.HasKey(e => e.Id);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}