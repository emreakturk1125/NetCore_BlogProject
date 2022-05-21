using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Context;
using Ysk.UdemyBlog.Entities.Concrete;
using Ysk.UdemyBlog.Entities.Concrete;

namespace YSKProje.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    //public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    //{
    //    public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
    //    {
    //        using var context = new BlogProjectContext();
    //        return await context.Categories.OrderByDescending(I=>I.Id).Include(I => I.CategoryBlogs).ToListAsync();
    //    }
    //}
}
