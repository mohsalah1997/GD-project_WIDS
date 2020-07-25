using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class Alert
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime timestamp { get; set; }
        public string description { get; set; }
        public int Status { get; set; }

    }
}
