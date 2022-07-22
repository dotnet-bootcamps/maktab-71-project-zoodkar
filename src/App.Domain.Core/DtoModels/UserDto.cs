using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class UserDto
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int PictureFileId { get; set; }
        public string HomeAddress { get; set; }
        public IList<string> Roles { get; set; }
    }
}
