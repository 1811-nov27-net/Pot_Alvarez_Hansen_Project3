using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class People
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string Zipcode { get; set; }

        public int CompanyNameId { get; set; }

        public ICollection<OrderHeaders> OrderHeadersBillingPerson { get; set; }

        public ICollection<OrderHeaders> OrderHeadersShippingPerson { get; set; }

    }
}
