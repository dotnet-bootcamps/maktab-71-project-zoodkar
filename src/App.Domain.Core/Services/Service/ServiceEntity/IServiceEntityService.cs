using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Domain.Core.Services.Service.ServiceEntity
{
    public interface IServiceEntityService
    {

        public Task<List<ServiceDto>> GetAllService();
        public Task<int> Add(ServiceDto model);
    }
}
