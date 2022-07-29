using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.MppingProfile.Profiles
{
    public class ServiceMappings:Profile
    {
        public ServiceMappings()
        {
            CreateMap<Service, ServiceDto>()
                .ReverseMap();
            CreateMap<Category, CategoryDto>()
               .ReverseMap()
               .EqualityComparison((SaveDto, Entity) => SaveDto.Id == Entity.Id);
          
            CreateMap<Order, OrderDto>()
              .ReverseMap()
             .EqualityComparison((SaveDto, Entity) => SaveDto.Id == Entity.Id);

        }
    }
}
