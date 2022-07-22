using App.Domain.Core.Data.ServiceEntity;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Database.SqlServer;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repository.Ef.ServiceEntity
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMapper _mapper;

        public CategoryRepository(AppDbContext dbContext,IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }

        public AppDbContext _DbContext { get; }

        public async Task<int> Add(CategoryDto Model)
        {
            var category = _mapper.Map<Category>(Model);
               
            await _DbContext.Categories.AddAsync(category);
            await _DbContext.SaveChangesAsync();
            return category.Id;
        }

        public async Task Delete(int id)
        {
            var category= await _DbContext.Categories.FirstAsync(x => x.Id == id);
            _DbContext.Categories.Remove(category);
        }

        public async Task Update(CategoryDto dto)
        {
            var category = await _DbContext.Categories.FirstAsync(x => x.Id == dto.Id);
            category = _mapper.Map<Category>(dto);
            await _DbContext.SaveChangesAsync();
        }
        public async Task<CategoryDto>? GetById(int id)
        {
            var entity = await _DbContext.Categories.SingleAsync(x => x.Id == id);
            var Dto = _mapper.Map<CategoryDto>(entity);

            return Dto;
        }



        public async Task<List<CategoryDto>> GetAll()
        {

            var ListDto = await _DbContext.Categories.ProjectTo<CategoryDto>(_mapper.ConfigurationProvider).ToListAsync();

            return ListDto;

        }

       
    }
}
