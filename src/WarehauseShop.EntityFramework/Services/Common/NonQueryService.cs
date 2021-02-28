using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WarehauseShop.EntityFramework.Services.Common
{
    public class NonQueryService<T> where T : class
    {
        private readonly WarehauseDbContextFactory _contextFactory;
        public NonQueryService(WarehauseDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<T> Create(T entity)
        {
            using (WarehauseDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createdResult.Entity;
            }
        }
    }
}
