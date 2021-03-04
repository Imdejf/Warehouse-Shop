using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace WarehauseShop.WebUI.Controllers
{
    public class HomeControllers : Controller
    {
        private readonly ILogger<HomeControllers> _logger;

        public HomeControllers(ILogger<HomeControllers> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
