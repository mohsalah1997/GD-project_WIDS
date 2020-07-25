using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class whitelist
    {

        public int ID { get; set; }
        public int ssid_id { get; set; }

        //public String mac { get; set; }
        public int? min_pwr { get; set; }
        public int? max_pwr { get; set; }
        public double channel { get; set; }

        public String cipher { get; set; }

        public String enc { get; set; }
        public String auth { get; set; }
    }
}
