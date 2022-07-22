using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.AppService.User
{
    public interface IUserAppService
    {
        Task<List<UserDto>> GetAll();
        Task<UserDto> GetByName(string name);
    }
}
