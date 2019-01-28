using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.Library
{
    public class Logs
    {
        public int Id { get; set; }

        public string LogLevel { get; set; }

        public DateTime TimeLogged { get; set; }

        public string LogMessage { get; set; }

    }
}
