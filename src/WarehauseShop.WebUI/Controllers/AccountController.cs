using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<AccountController> _logger;
        public AccountController(IMediator mediator, ILogger<AccountController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand loginCommand)
        {
            var result = await _mediator.Send(loginCommand);
            if (result.Succeeded)
            {
                _logger.LogInformation("Pomyślnie zalogowano");
                return Redirect("~/");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public async Task<IActionResult> Register(RegisterCommand registerCommand)
        {
            string role = Request.Form["rdUserRole"].ToString();
            registerCommand.Role = role;
           bool result = await _mediator.Send(registerCommand);
            if(result == true)
            {
                return Redirect("");
            }

            return View();
        }
    }
}
