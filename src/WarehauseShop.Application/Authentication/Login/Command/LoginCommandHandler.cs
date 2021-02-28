using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarehauseShop.Application.Common.Interfaces;
using WarehauseShop.Domain.Entites;

namespace WarehauseShop.Application.Authentication.Login.Command
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, SignInResult>
    {
        private readonly IAuthenticationService _authentication;
        private readonly SignInManager<IdentityUser> _signInManager;
        public LoginCommandHandler(IAuthenticationService authentication,SignInManager<IdentityUser> signInManager)
        {
            _authentication = authentication;
            _signInManager = signInManager;
        }
        public async Task<SignInResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            ApplicationUser user = await _authentication.GetByUsername(request.Username);
            SignInResult result = new SignInResult();
            if (user != null)
            {
                result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {

                }
                else
                {
                    result = SignInResult.NotAllowed;
                }
            }
            else
            {
                user = await _authentication.GetByEmail(request.Username);
                if(user != null)
                {
                    result = await _signInManager.PasswordSignInAsync(user.Email, request.Password, false, lockoutOnFailure: false);
                    if(result.Succeeded)
                    {
                        
                    }
                    else
                    {
                        result = SignInResult.NotAllowed;
                    }
                }
                else
                {
                    result = SignInResult.NotAllowed;
                }
            }
            return result;
        }
    }
}
