using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.EntityFramework
{
    public class WarehauseDbContext : IdentityDbContext, IWarehauseDbContext
    {
        public WarehauseDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
