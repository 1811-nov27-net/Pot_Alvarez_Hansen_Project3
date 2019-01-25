using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class OrderHeaders
    {
        public int Id { get; set; }

        public int BillingPersonId { get; set; }

        public int ShippingPersonId { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public ICollection<Invoice> Invoice { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
