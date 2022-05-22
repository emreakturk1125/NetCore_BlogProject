using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete; 

namespace Ysk.BlogProject.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
