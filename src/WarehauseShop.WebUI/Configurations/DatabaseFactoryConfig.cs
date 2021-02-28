using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WarehauseShop.EntityFramework;

namespace WarehauseShop.WebUI.Configurations
{
    public static class DatabaseFactoryConfig
    {
        public static void AddDatabaseFactoryConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentException(nameof(services));
            services.AddSingleton<WarehauseDbContextFactory>(new WarehauseDbContextFactory(s => s.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))));
        }
    }
}
