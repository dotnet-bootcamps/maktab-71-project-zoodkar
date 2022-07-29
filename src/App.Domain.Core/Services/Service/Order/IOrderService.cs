using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Service.Order
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAll();
    }
}
