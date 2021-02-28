using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.EntityFramework
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly WarehauseDbContextFactory _contextFactory;
        public AuthenticationService(WarehauseDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<ApplicationUser> GetByEmail(string email)
        {
            using(WarehauseDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.ApplicationUser.FirstOrDefaultAsync(e => e.Email == email);
            }
        }

        public async Task<ApplicationUser> GetByUsername(string username)
        {
            using(WarehauseDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.ApplicationUser.FirstOrDefaultAsync(s => s.UserName == username);
            }
        }
    }
}
