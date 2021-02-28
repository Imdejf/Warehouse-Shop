using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.EntityFramework;
using WarehauseShop.EntityFramework.Services;

namespace WarehauseShop.CrossCutting.loC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Domain
            #endregion


            #region Application
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IAuthorizationService, AuthorizationService>();
            #endregion

            #region Data - EntityFramework
            #endregion
        }
    }
}
