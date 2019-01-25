using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }


    }
}
