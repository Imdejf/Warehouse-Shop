using MediatR;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WarehauseShop.Application.Authentication.Login.Command
{
    public class LoginCommand : IRequest<SignInResult>
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
