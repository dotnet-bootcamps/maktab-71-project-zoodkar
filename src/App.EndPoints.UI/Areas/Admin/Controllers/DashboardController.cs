using App.Domain.Core.Entities;
using App.EndPoints.UI.Areas.Admin.Models;
using App.Infrastructures.Database.SqlServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
       
        public async Task<IActionResult> Index()
        {
           
            
            

            return View();
        }
    }
}
