using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete; 

namespace Ysk.BlogProject.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllSortedByIdAsync();
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
