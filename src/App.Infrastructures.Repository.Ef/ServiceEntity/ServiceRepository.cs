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
    public class ServiceRepository : IServiceRepository
    {
        public readonly AppDbContext _DbContext;
        public readonly IMapper _Mapper;
        public ServiceRepository(AppDbContext dbContext,IMapper mapper)
        {
             _DbContext = dbContext;
            _Mapper = mapper;
        }

        

        public async Task<int> Add(ServiceDto dto)
        {
            var service = _Mapper.Map<Service>(dto);
           
            await _DbContext.Services.AddAsync(service);
            await _DbContext.SaveChangesAsync();
            return service.Id;
        }

        public async Task Delete(int id)
        {
            var servic=await _DbContext.Services.SingleAsync(x=>x.Id==id);
             _DbContext.Services.Remove(servic);
            await _DbContext.SaveChangesAsync();
        }

        public async Task Update(ServiceDto dto)
        {
            var servic = await _DbContext.Services.SingleAsync(x => x.Id == dto.Id);
            servic=_Mapper.Map<Service>(dto);
            await _DbContext.SaveChangesAsync();

        }
        public async Task<ServiceDto>? GetById(int id)
        {
            var model = await _DbContext.Services.SingleAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("No Id Finded");
            }
            var servic = _Mapper.Map<ServiceDto>(model);
            return servic;
        }



        public async Task<List<ServiceDto>> GetAll()
        {
            var ListDto = await _DbContext.Services.ProjectTo<ServiceDto>(_Mapper.ConfigurationProvider).ToListAsync();
            return ListDto;
        }
    }
}
