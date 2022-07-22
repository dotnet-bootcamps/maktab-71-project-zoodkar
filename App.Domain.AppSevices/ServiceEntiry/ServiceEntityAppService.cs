using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.Service;
using App.Domain.Core.Services.Service.ServiceEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppSevices.ServiceEntiry
{
    public class ServiceEntityAppService : IServiceEntityAppService
    {
        public readonly IServiceEntityService _Service;
        public ServiceEntityAppService(IServiceEntityService serviceEntityService )
        {
            _Service= serviceEntityService;
        }
       
        public async Task<List<ServiceDto>> GetAllService()
        {
            return await _Service.GetAllService();
        }
    }
}
