using App.Domain.Core.Data.UploadFile;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EndPoints.UI.UploadFile
{
    public class UploadFileRepository : IUploadFileRepository
    {
        private readonly IWebHostEnvironment _webHost;

        public UploadFileRepository(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }
        public async Task<string> Add(IFormFile model)
        {
            if (model != null)
            {
                string FileName = Guid.NewGuid().ToString() + "-" + model.FileName;
                string PathFile = Path.Combine(_webHost.WebRootPath, "Image", FileName);
                await using (var FileStrim = new FileStream(PathFile, FileMode.Create))
                {
                    model.CopyTo(FileStrim);
                };
                return FileName;
            }
          return "not";
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IFormFile> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(IFormFile model)
        {
            throw new NotImplementedException();
        }
    }
}
