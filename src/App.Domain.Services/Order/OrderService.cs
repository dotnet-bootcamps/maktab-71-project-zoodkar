using App.Domain.Core.Data.Order;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Service.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<OrderDto>> GetAll()
        {
            return await _orderRepository.GetAll();
            
        }
    }
}
