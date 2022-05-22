using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete; 

namespace Ysk.BlogProject.DataAccess.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog>> GetLastFiveAsync();
    }
}
