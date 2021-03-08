using System;
using System.Collections.Generic;
using System.Text;
using WarehauseShop.Domain.IRepository;

namespace WarehauseShop.EntityFramework.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WarehauseDbContext _dbContext;
        public UnitOfWork(WarehauseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
