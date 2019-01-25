using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class Company
    {
        public Company()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}
