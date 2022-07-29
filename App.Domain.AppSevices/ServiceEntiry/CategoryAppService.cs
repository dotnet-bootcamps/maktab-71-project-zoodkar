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

        public async Task<int> Add(CategoryDto model)
        {
            return await _categoryService.Add(model);
        }

        public async Task<List<CategoryDto>> GetAllCategory()
        {
           return await _categoryService.GetAllCategory();
        }

        public async Task<CategoryDto> GetById(int id)
        {
            return await _categoryService.GetById(id);
        }

        public async Task Update(CategoryDto model)
        {
            await _categoryService.Update(model);
        }
    }
}
