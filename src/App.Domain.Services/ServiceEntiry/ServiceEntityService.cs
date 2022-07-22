using App.Domain.Core.Data.ServiceEntity;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.Service;
using App.Domain.Core.Services.Service.ServiceEntity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.ServiceEntiry
{
    public class ServiceEntityService : IServiceEntityService
    {
      
        public readonly IServiceRepository _ServiceRepository;

        public ServiceEntityService(IServiceRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
         
         
        }

        

       

        public async Task<List<ServiceDto>> GetAllService()
        {
            return await _ServiceRepository.GetAll();
        }
    }
}
