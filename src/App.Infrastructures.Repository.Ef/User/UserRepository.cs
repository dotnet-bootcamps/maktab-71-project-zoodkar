using App.Domain.Core.Data.User;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Database.SqlServer;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repository.Ef.User
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public UserRepository(AppDbContext dbContext,IMapper mapper, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<int> Add(UserDto model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> GetAll()
        {

            var users = await _userManager.Users.ToListAsync();
            var user = new List<UserDto>();
            foreach (var x in users)
            {

                var userDto = new UserDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    HomeAddress = x.HomeAddress,
    
                    IsActive = x.IsActive,
                    Roles = await _userManager.GetRolesAsync(x),
                };
                user.Add(userDto);
            }
           
            return user;
        }

        public async Task<UserDto> GetByName(string name)
        {
            var user = await _userManager.FindByNameAsync(name);
            return _mapper.Map<UserDto>(user);
        }

        public Task Update(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
