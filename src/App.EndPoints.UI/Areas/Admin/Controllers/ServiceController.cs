using App.Domain.Core.Services.AppService.ServiceEntity;
using App.EndPoints.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceEntityAppService _appServic;
        public readonly ICategoryAppService _CategoryApp;


        public ServiceController(IServiceEntityAppService appServic,ICategoryAppService categoryApp)
        {
            _appServic = appServic;
            _CategoryApp = categoryApp;
        }

       
        public async Task<IActionResult> Index()
        {
            var model = new ServiceViewModel
            {
                Categories = await _CategoryApp.GetAllCategory(),
                Services = await _appServic.GetAllService(),

            };
     
            return View(model);
        }
    }
}
