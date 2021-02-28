using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Application.Common.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ApplicationUser> GetByUsername(string username);
        Task<ApplicationUser> GetByEmail(string email);
    }
}
