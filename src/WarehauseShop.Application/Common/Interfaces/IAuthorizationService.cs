using System.Threading.Tasks;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Application.Common.Interfaces
{
    public interface IAuthorizationService
    {
        Task<ApplicationUser> CreateAccount(string username, string email, string password);
    }
}
