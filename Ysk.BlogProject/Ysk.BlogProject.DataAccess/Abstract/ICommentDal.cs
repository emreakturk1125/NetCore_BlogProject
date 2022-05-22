using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete; 

namespace Ysk.BlogProject.DataAccess.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
