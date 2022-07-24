using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.AppService.UploadFile;
using App.EndPoints.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceEntityAppService _appServic;
        public readonly ICategoryAppService _CategoryApp;
        private readonly IUploadFileAppService _uploadFile;

        public ServiceController(IServiceEntityAppService appServic,ICategoryAppService categoryApp,IUploadFileAppService uploadFile)
        {
            _appServic = appServic;
            _CategoryApp = categoryApp;
           _uploadFile = uploadFile;
        }

       
        public async Task<IActionResult> Index()
        {
            var model = await _CategoryApp.GetAllCategory();
            
            return View(model);
        }
        public async Task<IActionResult> AddService()
        {
            var Category = await _CategoryApp.GetAllCategory();
            ViewBag.Roles = Category.Select
            (s => new SelectListItem
            {
                Text = s.Title,
                Value = s.Id.ToString()
            }) ;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(ServiceDto model)
        {
            model.CategoryId = Convert.ToInt32(model.stringCategoryId);
            var add = await _appServic.Add(model);
            if (add == null)
            {
                throw new Exception("Error!!!!!!");
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> AddCategory()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryDto model)
        {
            var fileId = await _uploadFile.Add(model.File);
            model.FileId=fileId;
            var category = await _CategoryApp.Add(model);

            if (category==null)
            {
                throw new Exception("Error!!!!!");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category = await _CategoryApp.GetById(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(CategoryDto model)
        {
             await _CategoryApp.Update(model);
            return RedirectToAction("Index");
        }
    }
}
