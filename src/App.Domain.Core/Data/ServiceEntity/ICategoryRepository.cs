using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data.ServiceEntity
{
    public interface ICategoryRepository
    {
        #region "Queries"

        Task<CategoryDto> GetById(int id);
        Task<List<CategoryDto>> GetAll();

        #endregion



        #region "Commands"

        Task<int> Add(CategoryDto model);
        Task Update(CategoryDto model);
        Task Delete(int id);

        #endregion

    }
}
