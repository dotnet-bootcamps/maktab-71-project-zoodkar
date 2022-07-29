using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class OrderDto
    {
        public OrderDto()
        {
            Bids = new HashSet<Bid>();
            OrderFiles = new HashSet<OrderFile>();
            ServiceComments = new HashSet<ServiceComment>();
        }

        public int Id { get; set; }
        public byte StatusId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceBasePrice { get; set; }
        public int? CustomerUserId { get; set; }
        public int? FinalExpertUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual OrderStatus Status { get; set; } = null!;
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<OrderFile> OrderFiles { get; set; }
        public virtual ICollection<ServiceComment> ServiceComments { get; set; }
    }
}
