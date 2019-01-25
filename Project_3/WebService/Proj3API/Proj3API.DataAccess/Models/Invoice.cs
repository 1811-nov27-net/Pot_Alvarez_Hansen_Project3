using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int? OrderHeaderId { get; set; }
        public bool OrderPlaced { get; set; }
        public DateTime TimePlaced { get; set; }

        public virtual OrderHeaders OrderHeader { get; set; }
    }
}
