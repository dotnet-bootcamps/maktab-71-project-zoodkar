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
        public CategoryService(ICategoryRepository commandRepository ,ICategoryRepository queryRepository)
        {
            _CommandRepository = commandRepository;
            _QueryRepository = queryRepository;
        }

        public ICategoryRepository _CommandRepository { get; }
        public ICategoryRepository _QueryRepository { get; }

        public async Task<List<CategoryDto>> GetAllCategory()
        {
           return await _QueryRepository.GetAll();
        }
    }
}
