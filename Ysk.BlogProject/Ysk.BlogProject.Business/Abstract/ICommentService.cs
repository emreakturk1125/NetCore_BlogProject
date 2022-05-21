using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
