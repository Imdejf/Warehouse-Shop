using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using WarehauseShop.EntityFramework;

namespace WarehauseShop.CrossCutting.Identity
{
    public static class WarehauseIdentityConfig 
    {
        public static void AddWarehauseIdentityConfiguration(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<WarehauseDbContext>();
        }
    }
}
