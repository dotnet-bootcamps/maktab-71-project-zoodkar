using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.AppService.ServiceEntity
{
    public interface ICategoryAppService
    {
        public Task<List<CategoryDto>> GetAllCategory();
        public Task<int> Add(CategoryDto model);
        public Task<CategoryDto> GetById(int id);
        public Task Update(CategoryDto model);
    }
}
