using Microsoft.EntityFrameworkCore;
using Ysk.BlogProject.Entities.Concrete;

namespace sk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class BlogProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UdemyBlogTodo;Integrated Security=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new AppUserMap());
        //    modelBuilder.ApplyConfiguration(new BlogMap());
        //    modelBuilder.ApplyConfiguration(new CategoryMap());
        //    modelBuilder.ApplyConfiguration(new CategoryBlogMap());
        //    modelBuilder.ApplyConfiguration(new CommentMap());
        //}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
