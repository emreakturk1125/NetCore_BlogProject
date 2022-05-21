using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Business.Abstract;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Concrete
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        private readonly ICategoryDal _categoryDal;
 
        public CategoryService(IGenericDal<Category> genericDal, ICategoryDal categoryDal):base(genericDal)
        {
            _categoryDal = categoryDal;
            _genericDal = genericDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(I => I.Id);
        }

        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _categoryDal.GetAllWithCategoryBlogsAsync();
        }

        
    }
}
