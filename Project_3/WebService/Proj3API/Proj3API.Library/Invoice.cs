using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class Invoice
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }

        public bool OrderPlaced { get; set; }

        public DateTime TimePlaced { get; set; }

    }
}
