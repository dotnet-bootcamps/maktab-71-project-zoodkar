using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.AppService.Order;
using App.Domain.Core.Services.Service.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppSevices.Order
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IOrderService _orderService;

        public OrderAppService(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<List<OrderDto>> GetAll()
        {
            return await _orderService.GetAll();
        }
    }
}
