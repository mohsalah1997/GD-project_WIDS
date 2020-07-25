using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class user
    {
        [Key] 
        public int user_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int status { get; set; }

    }

}
