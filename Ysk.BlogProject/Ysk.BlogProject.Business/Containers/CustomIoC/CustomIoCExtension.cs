using Microsoft.Extensions.DependencyInjection;
using Ysk.BlogProject.Business.Abstract;
using Ysk.BlogProject.Business.Concrete;
using Ysk.BlogProject.DataAccess.Abstract;
using YSKProje.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Repositories;

namespace Ysk.BlogProject.Business.Containers.CustomIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>),typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>),typeof(GenericService<>));
        }
    }
}
