using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<List<Blog>> GetAllSortedByPostedTimeAsync();
        //Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        //Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog>> GetLastFiveAsync();
        Task<List<Blog>> SearchAsync(string searchString);
    }

    
}
