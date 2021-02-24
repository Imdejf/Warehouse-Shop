using Microsoft.Extensions.DependencyInjection;
using System;
using WarehauseShop.CrossCutting.loC;

namespace WarehauseShop.WebUI.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentException(nameof(services));
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
