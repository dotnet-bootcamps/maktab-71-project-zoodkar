using App.Domain.Core.Data.UploadFile;
using App.Domain.Core.Services.Service.UploadFile;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.UploadFile
{
    public class UploadFileService : IUploadFileService
    {
        private readonly IUploadFileRepository _uploadFileRepository;

        public UploadFileService(IUploadFileRepository uploadFileRepository)
        {
            _uploadFileRepository = uploadFileRepository;
        }
        public async Task<string> Add(IFormFile File)
        {
           return await _uploadFileRepository.Add(File);
        }

        public async Task<IFormFile> GetById(string FileId)
        {
           return await _uploadFileRepository.GetById(FileId);
        }

        public async Task Remove(string FileId)
        {
           await _uploadFileRepository.Delete(FileId);
        }

        public async Task Update(IFormFile File)
        {
           await _uploadFileRepository.Update(File);
        }
    }
}
