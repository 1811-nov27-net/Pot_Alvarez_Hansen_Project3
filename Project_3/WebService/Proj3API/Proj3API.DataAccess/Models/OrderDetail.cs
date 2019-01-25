using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

        public virtual OrderHeaders OrderHeader { get; set; }
        public virtual Products Product { get; set; }
    }
}
