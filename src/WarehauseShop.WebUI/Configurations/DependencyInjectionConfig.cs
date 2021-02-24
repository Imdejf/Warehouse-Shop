using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
