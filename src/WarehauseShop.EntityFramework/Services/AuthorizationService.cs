using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.EntityFramework.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        public Task<ApplicationUser> CreateAccount(string username, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
