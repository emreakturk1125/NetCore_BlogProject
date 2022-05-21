using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.BlogProject.Business.Abstract;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Concrete
{
    public class CommentService : GenericService<Comment>,ICommentService
    {
      
        private readonly ICommentDal _commentDal;
        public CommentService(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;
            
        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId, parentId);
        }
    }
}
