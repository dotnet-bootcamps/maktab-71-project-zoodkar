using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.AppService.User;
using App.Domain.Core.Services.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppSevices.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService )
        {
            _userService = userService;
        }
        public async Task<List<UserDto>> GetAll()
        {
            return await _userService.GetAll();
        }

        public async Task<UserDto> GetByName(string name)
        {
            return await _userService.GetByName(name);
        }
    }
}
