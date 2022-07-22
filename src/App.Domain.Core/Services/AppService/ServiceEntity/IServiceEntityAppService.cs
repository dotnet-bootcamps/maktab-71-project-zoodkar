using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DtoModels;
using  App.Domain.Core.Entities;

namespace App.Domain.Core.Services.AppService.ServiceEntity
{
    public interface IServiceEntityAppService
    {

        public  Task<List<ServiceDto>> GetAllService();
       
    }
}
