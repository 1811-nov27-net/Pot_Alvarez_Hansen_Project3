using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class People
    {
        public People()
        {
            OrderHeadersBillingPerson = new HashSet<OrderHeaders>();
            OrderHeadersShippingPerson = new HashSet<OrderHeaders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Zipcode { get; set; }
        public int? CompanyNameId { get; set; }

        public virtual Company CompanyName { get; set; }
        public virtual ICollection<OrderHeaders> OrderHeadersBillingPerson { get; set; }
        public virtual ICollection<OrderHeaders> OrderHeadersShippingPerson { get; set; }
    }
}
