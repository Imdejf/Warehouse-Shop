using System;
using System.Collections.Generic;
using System.Text;

namespace WarehauseShop.EntityFramework.Services.Interface
{
    public interface IUnitOfWork : IDisposable
    {

        void Save();
    }
}

