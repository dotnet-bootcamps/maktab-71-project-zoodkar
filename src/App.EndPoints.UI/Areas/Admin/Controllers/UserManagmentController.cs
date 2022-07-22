using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.AppService.User;
using App.EndPoints.UI.Areas.Admin.Models;
using App.Infrastructures.Database.SqlServer;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    public class UserManagmentController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly IMapper _mapper;
        private readonly IUserAppService _userAppService;

        public AppDbContext _DbContext { get; }

        public UserManagmentController(UserManager<AppUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            AppDbContext dbContext, IMapper mapper ,IUserAppService userAppService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _DbContext = dbContext;
            _mapper = mapper;
            _userAppService = userAppService;
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
        public async Task<IActionResult> Index()
        {
           
            var users = await _userAppService.GetAll();
            return View(users);
        }

    }
}
