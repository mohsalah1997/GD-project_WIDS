using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Alert> tbl_alert { get; set; }
        public DbSet<user> tbl_login { get; set; }
        public DbSet<ssids> ssids { get; set; }
        public DbSet<whitelist> whitelist { get; set; }




    }
}
