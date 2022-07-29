using App.Domain.Core.Data.Order;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Database.SqlServer;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repository.Ef.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        public IMapper _Mapper;
        public OrderRepository(AppDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _Mapper = mapper;
        }

       

        public Task<int> Add(OrderDto model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDto>> GetAll()
        {
            var list = await _dbContext.Orders.ProjectTo<OrderDto>(_Mapper.ConfigurationProvider).ToListAsync();
            return list;
        }

        public Task<OrderDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(OrderDto model)
        {
            throw new NotImplementedException();
        }
    }
}
