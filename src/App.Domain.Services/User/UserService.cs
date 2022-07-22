using App.Domain.Core.Data.User;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<UserDto>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task<UserDto> GetByName(string name)
        {
            return await _userRepository.GetByName(name);
        }
    }
}
