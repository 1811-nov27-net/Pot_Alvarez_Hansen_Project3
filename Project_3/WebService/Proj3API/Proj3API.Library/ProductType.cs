﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class ProductType
    {
        public int Id { get; set; }

        public string TypeName { get; set; }


        public ICollection<Products> Products { get; set; }
    }
}
