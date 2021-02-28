using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehauseShop.Application.Authentication.Login.Command;
using WarehauseShop.Application.Authentication.Register;

namespace WarehauseShop.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand loginCommand)
        {
            await _mediator.Send(loginCommand);
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommand registerCommand)
        {
            string role = Request.Form["rdUserRole"].ToString();
            registerCommand.Role = role;
           bool result = await _mediator.Send(registerCommand);
            if(result == true)
            {
                return Redirect("Login");
            }

            return View();
        }
    }
}
