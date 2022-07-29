using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Data.UploadFile
{
    public interface IUploadFileRepository
    {
        #region "Queries"

        Task<IFormFile> GetById(string id);
        
        #endregion



        #region "Commands"

        Task<string> Add(IFormFile model);
        Task Update(IFormFile model);
        Task Delete(string id);

        #endregion
    }
}
