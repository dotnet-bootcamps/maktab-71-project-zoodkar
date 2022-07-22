using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data.Order
{
    public interface IOrderRepository
    {

        #region "Queries"

        Task<OrderDto> GetById(int id);
        Task<List<OrderDto>> GetAll();

        #endregion



        #region "Commands"

        Task<int> Add(OrderDto model);
        Task Update(OrderDto model);
        Task Delete(int id);

        #endregion

    }
}
