using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WarehauseShop.EntityFramework
{
    public class WarehauseDbContext : IdentityDbContext
    {
        public WarehauseDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
