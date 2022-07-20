using App.Domain.Core.Entities;
using App.EndPoints.UI.Areas.Admin.Models;
using App.Infrastructures.Database.SqlServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "AdminRole")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        public AppDbContext _DbContext { get; }
        public DashboardController(UserManager<AppUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            AppDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _DbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var users=await _userManager.Users.Select( x => new UsersViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                HomeAddress = x.HomeAddress,
                Id= x.Id,
                IsActive = x.IsActive,
                Roles=_userManager.GetRolesAsync(x),
            }).ToListAsync();
            

            return View(users);
        }
    }
}
