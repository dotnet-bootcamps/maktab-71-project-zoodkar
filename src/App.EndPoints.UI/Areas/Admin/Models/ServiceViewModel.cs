using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.EndPoints.UI.Areas.Admin.Models
{
    public class ServiceViewModel
    {
        public List<ServiceDto> Services { get; set; }
        public List<CategoryDto> Categories { get; set; }
    }
}
