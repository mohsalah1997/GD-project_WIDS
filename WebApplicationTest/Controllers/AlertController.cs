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
    public class AlertController : ControllerBase
    {
        private readonly DataContext _context;

        public AlertController(DataContext context) {
           _context = context;
        }

        // GET: api/Alert
        [HttpGet]
        public IEnumerable<Alert> Get() => _context.tbl_alert.ToList().Where(x => x.Status == 1);

        [Route("Archive/{i}")]
      [HttpPost]
        public IActionResult Post(int i)
        {
            var entity = _context.tbl_alert.FirstOrDefault(item => item.ID == i);
            if (entity != null)
            {
                // Answer for question #2

                // Make changes on entity
                entity.Status = 0;
                

                // Update entity in DbSet
                _context.tbl_alert.Update(entity);

                // Save changes in database
                _context.SaveChanges();
            }

            return Ok();
        }

    }
}
