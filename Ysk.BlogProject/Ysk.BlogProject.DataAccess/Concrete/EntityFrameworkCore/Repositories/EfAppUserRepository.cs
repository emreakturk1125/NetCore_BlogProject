using System;
using System.Collections.Generic;
using System.Text;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
    }
}
