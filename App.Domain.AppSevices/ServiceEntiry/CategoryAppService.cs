using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.Service.ServiceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppSevices.ServiceEntiry
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }
        public async Task<List<CategoryDto>> GetAllCategory()
        {
           return await _categoryService.GetAllCategory();
        }
    }
}
