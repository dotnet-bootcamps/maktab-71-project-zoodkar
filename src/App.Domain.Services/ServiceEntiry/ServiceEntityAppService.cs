using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.AppService.ServiceEntity;
using App.Domain.Core.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.ServiceEntiry
{
    public class ServiceEntityAppService : IServiceEntityAppService
    {
        public readonly IServiceEntityServic _Service;
        public ServiceEntityAppService(IServiceEntityServic serviceEntityService )
        {
            _Service= serviceEntityService;
        }
        public async Task<List<CategoryDto>> GetAllCategory()
        {
            return await _Service.GetAllCatedory();
        }

        public async Task<List<ServiceDto>> GetAllService()
        {
            return await _Service.GetAllService();
        }
    }
}
