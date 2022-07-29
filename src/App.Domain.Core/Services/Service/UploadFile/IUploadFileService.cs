using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Service.UploadFile
{
    public interface IUploadFileService
    {
        Task<string> Add(IFormFile File);
        Task<IFormFile> GetById(string FileId);
        Task Remove(string FileId);
        Task Update(IFormFile File);
    }
}
