using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        //Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
