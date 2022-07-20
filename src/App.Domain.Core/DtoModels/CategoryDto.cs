using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Display(Name ="عنوان")]
        public string Title { get; set; } = null!;

        public virtual ICollection<ExpertFavoriteCategory> ExpertFavoriteCategories { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
