using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
