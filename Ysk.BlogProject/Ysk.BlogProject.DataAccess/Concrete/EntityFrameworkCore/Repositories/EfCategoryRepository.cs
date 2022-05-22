using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Context;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new BlogProjectContext();
            return await context.Categories.OrderByDescending(I => I.Id).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}
