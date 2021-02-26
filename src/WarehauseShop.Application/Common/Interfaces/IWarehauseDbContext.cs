using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Application.Common.Interfaces
{
    public interface IWarehauseDbContext
    {
        DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
