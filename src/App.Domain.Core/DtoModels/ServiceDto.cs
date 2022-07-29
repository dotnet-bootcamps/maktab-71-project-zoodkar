using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class ServiceDto
    {
        public int Id { get; set; }
        [Display(Name ="شناسه دسته بندی")]
        public int CategoryId { get; set; }
        public string stringCategoryId { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; } = null!;
        public string? ShortDescription { get; set; }
        [Display(Name = "قیمت پایه ")]
        public int Price { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServiceComment> ServiceComments { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
       
    }
}
