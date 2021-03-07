using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehauseShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return Redirect("~/");
            }
        }
    }
}
