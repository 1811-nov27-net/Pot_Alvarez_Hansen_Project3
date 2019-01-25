using System;
using System.Collections.Generic;

namespace Proj3API.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string LogLevel { get; set; }
        public DateTime? TimeLogged { get; set; }
        public string LogMessage { get; set; }
    }
}
