using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
