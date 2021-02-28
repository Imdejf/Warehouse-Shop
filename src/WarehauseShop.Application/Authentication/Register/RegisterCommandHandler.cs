using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.Domain;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Application.Authentication.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand,bool>
    {
        private readonly IAuthenticationService _authentication;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public RegisterCommandHandler(IAuthenticationService authentication,UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _authentication = authentication;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            ApplicationUser user = await _authentication.GetByEmail(request.Email);
            if (user == null)
            {
                user = await _authentication.GetByUsername(request.Username);
                if (user == null)
                {
                    var createUser = new ApplicationUser
                    {
                        UserName = request.Username,
                        Email = request.Email,
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        PhoneNumber = request.PhoneNumber,
                    };
                   var result = await _userManager.CreateAsync(createUser,request.Password);
                    if(result.Succeeded)
                    {
                        _roleManager.CreateAsync(new IdentityRole(SD.AdminRole)).GetAwaiter().GetResult();
                        _roleManager.CreateAsync(new IdentityRole(SD.CustomerRole)).GetAwaiter().GetResult();
                        if(request.Role == SD.AdminRole)
                        {
                            await _userManager.AddToRoleAsync(createUser, SD.AdminRole);
                        }
                        else if(request.Role == SD.CustomerRole)
                        {
                            await _userManager.AddToRoleAsync(user, SD.CustomerRole);
                        }
                        else
                        {
                            return false;   
                        }
                    }
                }
                else
                {
                    return false;
                }
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
