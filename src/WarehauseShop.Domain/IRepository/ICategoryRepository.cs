using System;
using System.Collections.Generic;
using System.Text;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Domain.IRepository
{
    public interface ICategoryRepository : IRepositoryAsync<Category>
    {
        void Update(Category category);
    }
}
