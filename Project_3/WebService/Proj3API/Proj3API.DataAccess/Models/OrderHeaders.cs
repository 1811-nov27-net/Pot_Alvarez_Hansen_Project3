using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class OrderHeaders
    {
        public OrderHeaders()
        {
            Invoice = new HashSet<Invoice>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int BillingPersonId { get; set; }
        public int ShippingPersonId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public virtual People BillingPerson { get; set; }
        public virtual People ShippingPerson { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
