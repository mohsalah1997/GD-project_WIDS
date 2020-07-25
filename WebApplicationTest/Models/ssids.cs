using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class ssids
    {

        public int ID { get; set; }
        public String mac { get; set; }
        public String ssid { get; set; }
       
        public int pwr { get; set; }
        public double channel { get; set; }

        public String cipher { get; set; }

        public String enc { get; set; }
        public String auth { get; set; }
    }
}
