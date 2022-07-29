using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data.ServiceEntity
{
    public interface IServiceRepository
    {
        #region "Queries"

        Task<ServiceDto> GetById(int id);
        Task<List<ServiceDto>> GetAll();

        #endregion



        #region "Commands"

        Task<int> Add(ServiceDto model);
        Task Update(ServiceDto model);
        Task Delete(int id);

        #endregion
    }
}
