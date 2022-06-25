using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Ysk.BlogProject.Entities.Concrete;

namespace Ysk.BlogProject.WebApi.Identity
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new Entities.Concrete.AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new Entities.Concrete.AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                Entities.Concrete.AppUser user = new Entities.Concrete.AppUser { Name = "Admin", Surname = "Admin", UserName = "admin", Email = "emre@gmail.com" };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
