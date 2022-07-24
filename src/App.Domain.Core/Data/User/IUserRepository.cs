using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data.User
{
    public interface IUserRepository
    {
        #region "Queries"

        Task<UserDto> GetByName(String name);
        Task<List<UserDto>> GetAll();
        Task<List<string>> GetAllRoles();

        #endregion



        #region "Commands"

        Task<int> Add(UserDto model);
        Task Update(UserDto model);
        Task Delete(int Id);

        #endregion
    }
}
