using App.Domain.Core.Entities;

namespace App.EndPoints.UI.Areas.Admin.Models
{
    public class ServiceViewModel
    {
        public List<Service> Services { get; set; }
        public List<Category> Categories { get; set; }
    }
}
