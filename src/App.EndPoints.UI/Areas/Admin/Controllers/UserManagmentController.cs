using App.Domain.Core.Entities;
using App.Infrastructures.Database.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    public class UserManagmentController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        public AppDbContext _DbContext { get; }

        public UserManagmentController(UserManager<AppUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            AppDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _DbContext = dbContext;
        }

        

        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(string Role)
        {

            if (!_DbContext.Roles.Any(r => r.Name == Role))
            {
                var role = new IdentityRole<int> { Name = Role };



                await _roleManager.CreateAsync(role);
                
                await _DbContext.SaveChangesAsync();
            } 

               
                return View();
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
