using System.Threading.Tasks;
using Ysk.BlogProject.Business.Abstract;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.Business.Concrete
{
    public class AppUserService : GenericService<AppUser>, IAppUserService     
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserService(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        //public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        //{
        //    return await _genericDal.GetAsync(I => I.UserName == appUserLoginDto.UserName && I.Password == appUserLoginDto.Password);
        //}

        public async Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(I => I.UserName == userName);
            
        }
    }
}
