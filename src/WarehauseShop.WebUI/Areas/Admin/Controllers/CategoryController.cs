using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehauseShop.Domain.Entites;

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
        public async Task<IActionResult> Upsert(int? id)
        {
            Category category = new Category();
            return View(category);
        }
        [HttpGet]
        public IActionResult OnGet(int? id)
        {
            return View();
        }
    }
}
