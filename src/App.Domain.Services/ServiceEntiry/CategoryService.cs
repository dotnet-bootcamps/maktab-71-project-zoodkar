using App.Domain.Core.Data.ServiceEntity;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Service.ServiceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.ServiceEntiry
{
    public class CategoryService : ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository )
        {
            _CategoryRepository = categoryRepository;
           
        }

        public ICategoryRepository _CategoryRepository;

        public async Task<int> Add(CategoryDto model)
        {
           return await _CategoryRepository.Add( model );
        }

        public async Task<List<CategoryDto>> GetAllCategory()
        {
           return await _CategoryRepository.GetAll();
        }

        public async Task<CategoryDto> GetById(int id)
        {
            return await _CategoryRepository.GetById( id );
        }

        public async Task Update(CategoryDto model)
        {
            await _CategoryRepository.Update(model);
        }
    }
}
