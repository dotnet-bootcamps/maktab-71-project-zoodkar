using App.Domain.Core.Services.AppService.UploadFile;
using App.Domain.Core.Services.Service.UploadFile;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppSevices.UploadFile
{
    public class UploadFileAppService : IUploadFileAppService
    {
        private readonly IUploadFileService _uploadFileService;

        public UploadFileAppService(IUploadFileService uploadFileService )
        {
            _uploadFileService = uploadFileService;
        }
        public async Task<string> Add(IFormFile File)
        {
           return await _uploadFileService.Add( File );
        }

        public async Task<IFormFile> GetById(string FileId)
        {
            return await _uploadFileService.GetById( FileId );
        }

        public async Task Remove(string FileId)
        {
            await _uploadFileService.Remove( FileId );
        }

        public async Task Update(IFormFile File)
        {
            await _uploadFileService.Update( File );
        }
    }
}
