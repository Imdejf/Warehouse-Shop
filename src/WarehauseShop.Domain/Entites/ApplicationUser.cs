using Microsoft.AspNetCore.Identity;

namespace WarehauseShop.Domain.Entites
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
