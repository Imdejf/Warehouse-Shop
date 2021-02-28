using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarehauseShop.EntityFramework
{
    public class WarehauseDbContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;
        public WarehauseDbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }
        public WarehauseDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<WarehauseDbContext> options = new DbContextOptionsBuilder<WarehauseDbContext>();
            _configureDbContext(options);
            return new WarehauseDbContext(options.Options);
        }
    }
}
