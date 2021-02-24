using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WarehauseShop.EntityFramework;

namespace WarehauseShop.WebUI.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentException(nameof(services));
            services.AddDbContext<WarehauseDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
