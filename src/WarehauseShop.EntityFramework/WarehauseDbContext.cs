using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarehauseShop.EntityFramework
{
    public class WarehauseDbContext : DbContext
    {
        public WarehauseDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
