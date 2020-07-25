using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class archiveController : ControllerBase
    {

        private readonly DataContext _context;

        public archiveController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Alert
        [HttpGet]
        public IEnumerable<Alert> Get() => _context.tbl_alert.ToList();
    }
}